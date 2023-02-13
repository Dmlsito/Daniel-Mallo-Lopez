using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json.Linq;
using RestSharp;
using DataFormat = RestSharp.DataFormat;

namespace WPFApis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        RestClient client = new RestClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            imprimirLista();
        }

        public void imprimirLista()
        {
            var request = new RestRequest("https://coronavirus.m.pipedream.net/", Method.Get);
            
            request.RequestFormat = DataFormat.Json;
            var res = client.Execute(request);
            //Almaceno el json
            JObject json = JObject.Parse(res.Content);
            //Le indicamos que objeto debe recorrer, en este caso para probar que recorra el objeto que engloba a todos los demas objetos
            JArray array = (JArray)json["nonChina"];
            IList<Pais> lista = array.ToObject<IList<Pais>>();
            foreach(var i in lista)
            {
                Box.Text = i.deaths.ToString();
            }
            
           

           
           
           


            /*

             JArray array = (JArray)data["summaryStats"];

            List<String> dataList = new List<String>();
            foreach(var item in array)
            {
                dataList.Add((String)item["nonchina"]["deaths"]);
            }
            foreach(String muertes in dataList){
                Box.Text = muertes;
            }
            */
            

            
           
           

            

            
            


           

            /*
            request.RequestFormat = DataFormat.Json;
            var respuesta = client.Execute(request);
            JObject dataObject = JObject.Parse(respuesta.Content);

            Box.Text = dataObject.ToString();
            */


        }
    }
}
