using System;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;

namespace Don_Skraper

{
    public partial class Form1 : Form
    {
        private const string V = "w";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {

            string key = "100bac7a1967b5ae449c809294025f3e0bc645d4878274028d042a88cb784483";
            string ip = textBox3.Text;
            string url = "http://api.ipinfodb.com/v3/ip-city/?key=" + key + "&ip=" + ip;

            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(string.Format(url));

            webReq.Method = "GET";

            HttpWebResponse webResponse = (HttpWebResponse)webReq.GetResponse();

            Stream answer = webResponse.GetResponseStream();

            StreamReader response = new StreamReader(answer);

            string raw = response.ReadToEnd();

            char[] delimiter = new char[1];

            delimiter[0] = ';';

            string[] rawdata = raw.Split(delimiter);



            string[] lines = {
            "-->>> Running            " + rawdata[0] +

           "-->>> IP                    " + rawdata[2]

          + "-->>> Country Code:      " + rawdata[3]

            + "-->>> Nombre del Pais:   " + rawdata[4]

             + "-->>> State:                 " + rawdata[5]

           + "-->>> Ciudad:                " + rawdata[6]

       + "-->>> Codigo Postal:         " + rawdata[7]

          + "-->>> Latitud:              " + rawdata[8]

              + "-->>> Longitud:             " + rawdata[9] +

             "-->>> Date:                 " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + " (UTC" + rawdata[10] + ")"

        };


            textBox5.Text = ("-->>> Running            " + rawdata[0]);

            textBox6.Text = ("-->>> IP                    " + rawdata[2]);

            textBox7.Text = ("-->>> Country Code:      " + rawdata[3]);

            textBox8.Text = ("-->>> Nombre del Pais:   " + rawdata[4]);

            textBox9.Text = ("-->>> State:                 " + rawdata[5]);

            textBox10.Text = ("-->>> Ciudad:                " + rawdata[6]);

            textBox11.Text = ("-->>> Codigo Postal:         " + rawdata[7]);

            textBox12.Text = ("-->>> Latitud:              " + rawdata[8]);

            textBox13.Text = ("-->>> Longitud:             " + rawdata[9]);

            textBox14.Text = ("-->>> Date:                 " + DateTime.Now.ToString("MM/dd/yyyy h:mm tt") + " (UTC" + rawdata[10] + ")");


            
           

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        
        public void textBox4_TextChanged_1(object sender, EventArgs e)
        {


            System.Diagnostics.Process.Start("www.instagram.com/opdel_dev");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com/juan.vial.rt");
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
         

        }

        public void button3_Click(object sender, EventArgs e)
        {
            
           string[] lines = { textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text + textBox13.Text + textBox14.Text + "/n"};

            using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"\Don Skraper\Records.txt", true))
            {
                file.WriteLine("Fourth line");
            }

            /*using (System.IO.StreamWriter file =
    new System.IO.StreamWriter(@"Records.txt"))
            {
                
                file.wri(lines[0]);
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            }       */

        }

        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {
        //    string[] lines = File.ReadAllLines(@"C:\Users\juanv\source\repos\Don Skraper\Don Skraper\Records.txt");
          
            /*
             var fileStream = new FileStream(@"Records.txt", FileMode.Open, FileAccess.Read);
             using (var streamReader = new StreamReader(fileStream))
             {
             textBox4.Text = streamReader.ReadToEnd();
             }      */
        }

        private void textBox4_TextChanged_3(object sender, EventArgs e)
        {
            string key = "100bac7a1967b5ae449c809294025f3e0bc645d4878274028d042a88cb784483";
            string ip = textBox3.Text;
            string url = "http://api.ipinfodb.com/v3/ip-city/?key=" + key + "&ip=" + ip;

            HttpWebRequest webReq = (HttpWebRequest)WebRequest.Create(string.Format(url));

            webReq.Method = "GET";

            HttpWebResponse webResponse = (HttpWebResponse)webReq.GetResponse();

            Stream answer = webResponse.GetResponseStream();

            StreamReader response = new StreamReader(answer);

            string raw = response.ReadToEnd();

            char[] delimiter = new char[1];

            delimiter[0] = ';';

            string[] rawdata = raw.Split(delimiter);


            rawdata[2].ToString();


            ip = rawdata[2];

            var direction = (Console.ReadLine());

            IPAddress iP = IPAddress.Parse(ip); //Google


            Ping ping = new Ping();
            var i = 0;
            i = i * 0;
            while (i < 5)
            {
                i++;
                PingReply pr = ping.Send(ip);
                Console.WriteLine("Respuesta desde (0): bytes:(1) tiempo=(2) ((3))",
                                            pr.Address, pr.Buffer.Length, pr.RoundtripTime,
                                            pr.Status.ToString());

            }
        }

        private void TextBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
