using System;
using System.IO.Ports;



namespace DR.ExposeSimulator.Com
{
    public class AutoExp
    { 
        SerialPort _serialPort1 = new SerialPort();
        public String PortName ;
       
    
   
       
       
        
        public void Connect()
        {
            try
            {
                _serialPort1.PortName = "COM17";
                _serialPort1.BaudRate = 9600;
                _serialPort1.Parity = Parity.None;
                _serialPort1.DataBits = 8;
                _serialPort1.StopBits = StopBits.One;
                  
                  

                if (_serialPort1.IsOpen)
                {
                    _serialPort1.Close();

                }
                _serialPort1.Open();
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }

        public int keeptime;
        readonly byte[] j = new byte[9] {0x00, 0x5A, 0x53, 0x00, 0x01, 0x01, 0x00, 0x00, 0xAF};
        readonly byte[] k = new byte[9] {0x00, 0x5A, 0x53, 0x00, 0x01, 0x02, 0x00, 0x00, 0xB0 };
        readonly byte[] l = new byte[9] {0x00, 0x5A, 0x53, 0x00, 0x04, 0x00, 0x00, 0x00, 0xB1 };
 
     
   

        public int Pre(int keeptime)
        {
            try
            {
                _serialPort1.Write(j,0,9);

            
               
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
            return 1;

        }
    
       


        public int Expose()
        {
            try
            {
               
                _serialPort1.Write(k, 0, 9);

     
   
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
            return 2;
        }
        public void Res()
        {
            try
            {
                
              _serialPort1.Write(l, 0, 9);
               
      
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }

       
       
        public void DisConnect()
        {
            try
            { if (_serialPort1.IsOpen)
                {
                    _serialPort1.Close();
                }
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }

       
 
    }
}
