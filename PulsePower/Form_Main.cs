

using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

using Modbus.Device;

using PulsePower.Helpers;

namespace PulsePower
{
    public partial class Form_Main : Form
    {

        SerialPort serialPort = new SerialPort();
        ModbusSerialMaster master;

        public Form_Main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            #region Serialinit
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comcmb.Items.Clear();
            comcmb.Items.AddRange(ports);
            comcmb.SelectedIndex = comcmb.Items.Count > 0 ? 0 : -1;
            #endregion
        }

        private void 退出软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DoClosingBeforeEvent();
            base.OnClosing(e);
        }

        private void DoClosingBeforeEvent()
        {
            if (master != null)
            {
                master.Dispose();
                master = null;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    GetData.Enabled = false;
                    master.Dispose();
                    serialPort.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (serialPort.IsOpen == false)
            {

                try
                {
                    serialPort.PortName = comcmb.Text;
                    serialPort.BaudRate = 9600;
                    serialPort.DataBits = 8;
                    serialPort.Parity = Parity.None;
                    serialPort.StopBits = StopBits.One;//一般是1位停止位
                    serialPort.Open();
                    master = ModbusSerialMaster.CreateRtu(serialPort);
                    master.Transport.Retries = 2;   //don't have to do retries
                    master.Transport.ReadTimeout = 300; //milliseconds
                    master.Transport.WaitToRetryMilliseconds = 0;
                    master.Transport.WriteTimeout = 80;
                    GetData.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"串口打开失败！\r\n可能原因:{ex.Message}");
                }
            }
            btnConnect.Text = serialPort.IsOpen ? "关闭串口" : "打开串口";
        }

        private void timerGetData_Tick(object sender, EventArgs e)
        {
            try
            {
                timerGetData();
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        #region FormMove
        private Point mPoint = new Point();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint.X = e.X;
            mPoint.Y = e.Y;
        }

        private void Form1_MouseMoveForm_Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myPosittion = MousePosition;
                myPosittion.Offset(-mPoint.X, -mPoint.Y);
                Location = myPosittion;
            }
        }
        #endregion

        private void Form_Main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {

                ushort valWidth = (ushort)Int16.Parse(textBoxPulseWidth.Text);
                ushort valTimes = (ushort)Int16.Parse(textBoxTimesOfLow.Text);
                float valCurrent = (float)float.Parse(textBoxCurrent.Text);
                byte valNumber = byte.Parse(textboxNumber.Value.ToString());
                byte valHz = byte.Parse(textboxHz.Value.ToString());

                byte u8Temp = (byte)((valNumber << 4) + valTimes);
                ushort u16Temp = (ushort)(((ushort)u8Temp << 8) + valHz);

                var bytes = BitConverter.GetBytes(valCurrent);
                ushort valCurrent1 = (ushort)BitConverterHelper.ToInt16(bytes, 0);
                ushort valCurrent2 = (ushort)BitConverterHelper.ToInt16(bytes, 2);
                master?.WriteMultipleRegisters(1, 0, new ushort[] 
                {
                    u16Temp,
                    valWidth,
                    Convert.ToUInt16(valCurrent),
                });
                timerGetData();
            }
            catch
            {

            }
        }

        void timerGetData()
        {
            byte slaveID = 1;
            ushort startAddress = 0;
            ushort numofPoints = 8;  //数据帧中 word 的数量
            ushort[] holdingregister = master.ReadHoldingRegisters(slaveID, startAddress, numofPoints);
            var u16Temp = holdingregister[0];
            labelPulseWidth.Text = "脉宽:" + (holdingregister[1] * 20 /1000.0).ToString() + "us";
            labelTimesOfLow.Text = "脉间:" + ((holdingregister[0] >> 8) & 0x0f).ToString() + "倍";
            labelCurrent.Text = "电流:" + (holdingregister[2] / 10.0).ToString() + "A";
            labelNumber.Text = "组态号：" + (holdingregister[0] >> 12);
            labelHz.Text = "丝速：" + (byte)(holdingregister[0]) + "Hz";
            byte[] bytes = { };
            for (int i = 0; i < numofPoints; i++)
            {
                byte[] byteTemp;
                byteTemp = BitConverter.GetBytes(holdingregister[i]);
                bytes = BitConverterHelper.BytesConnect(bytes, byteTemp);
            }
            labelStatus.Text = "";
            foreach (var b in bytes)
            {
                labelStatus.Text += b.ToString() + " ";
            }
        }
    }
}
