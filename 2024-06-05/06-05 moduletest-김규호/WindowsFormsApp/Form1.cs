using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//추가
using System.Net.Http;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void conn_btn_Click(object sender, EventArgs e)
        {


            String port = this.comboBox1.Items[this.comboBox1.SelectedIndex].ToString(); // comboBox 에서 선택한 index 추출 해서 String 형태로 반환 후 String port에 저장
            Console.WriteLine("PORT : " + port); // 콘솔에 port 출력
            HttpWebRequest request = null;  //서버에서 원격 웹사이트의 데이터를 받아서 처리를 할 때 C#으로 구현하는 방법, 원격 데이터를 읽을 때는 HttpWebRequest 객체를 사용
            HttpWebResponse response = null; //HTTP 요청을 보내고 HTTP 응답을 수신 하는 HTTP 독립 실행형 클라이언트 애플리케이션을 구축 하는 데 사용 됩니다.
            try
            {
                request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/connection/" + port);
                //HttpWebRequest.Create()은 .NET 프레임워크에서 HTTP 요청을 생성하기 위한 메서드
                //이를 사용하여 원격 서버로 HTTP 요청을 보냄
                //일반적으로 웹 서비스를 호출하거나 웹 페이지의 내용을 가져오는 등의 작업에 사용
                request.Method = "GET"; // 메서드 설정 GET 방식으로 설정
                request.ContentType = "application/json"; // ContentType 설정 
                //request.Timeout = 30 * 1000;

                // request.GetResponse() : 객체를 사용하여 HTTP 요청을 보내고, 서버로부터의 응답을 받기 위해 호출
                response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.OK) // HTTP 요청이 성공적으로 처리 되었을 경우를 뜻함
                {
                    Console.WriteLine("RESPONSE CODE : " + response.StatusCode);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex : " + ex);
            }


        }

        private void led_on_btn_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/led/1");
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

        private void led_off_btn_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/led/0");
            request.Method = "GET";
            request.ContentType = "application/json";
            //request.Timeout = 30 * 1000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/led");
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII); // StreamReader로 response에 들어온 값 저장
            string responseText = reader.ReadToEnd(); // 응답을 텍스트로 읽음
            textBox1.Text = responseText; // 텍스트 상자에 응답 텍스트 설정
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/tmp");
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
            string responseText = reader.ReadToEnd();
            textBox2.Text = responseText;
        }

        private async void textBox3_TextChanged(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/tmp");
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
            string responseText = reader.ReadToEnd();
            textBox3.Text = responseText;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:8080/arduino/message/distance");
            request.Method = "GET";
            request.ContentType = "application/json";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.ASCII);
            string responseText = reader.ReadToEnd();
            textBox4.Text = responseText;

        }
    }
}
