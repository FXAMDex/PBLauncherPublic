using Newtonsoft.Json;
using PBLauncher.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher.AMDex
{
    public class Location
    {
        public string country_name { get; set; }
        public string region { get; set; }
        public string City { get; set; }
    }
    public class AMDexCustom
    {
        public static string GetManufacture()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");
                ManagementObjectCollection collection = searcher.Get();
                foreach (ManagementObject obj in collection)
                {
                    string manufacturer = obj["Vendor"].ToString();
                    string product = obj["Name"].ToString();
                    return $"{manufacturer}";
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error getting manufacturer: " + ex.ToString());
            }
            return "Unable to get system product information";
        }
        public static string GetHwid()
        {
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    string processorId = obj["ProcessorId"].ToString();
                    return processorId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil Data Comouter: " + ex.Message);
            }

            return string.Empty;
        }
        public static string GetPublicIpAddress()
        {
            try
            {
                string url = "https://api.ipify.org";
                using (var client = new WebClient())
                {
                    var responseString = client.DownloadString(url);
                    Logger.Log("[UPDATER_STATE_PRE_UPDATER_VERSION_ACK]-> [UPDATER_STATE_PATCH_END] try state change");
                    return responseString;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error getting public IP address: " + ex.ToString());
                return "";
            }
        }
        public static string GetPublicIpv6Address()
        {
            var nics = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var nic in nics)
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }

            return "";
        }
        public static string GetCityFromIPAddress()
        {
            try
            {
                string url = $"https://ipapi.co/city/";
                using (var client = new WebClient())
                {
                    string city = client.DownloadString(url);
                    return city;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error getting city from IP address: " + ex.ToString());
                return "";
            }
        }
        public static string GetRegionData()
        {
            string ipAddress = GetPublicIpAddress();
            try
            {
                string url = $"https://freegeoip.app/json/{ipAddress}";
                using (var client = new WebClient())
                {
                    string response = client.DownloadString(url);
                    Location location = JsonConvert.DeserializeObject<Location>(response);
                    return location.country_name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting location from IP address: " + ex.ToString());
                return "Gagal mendapatkan lokasi";
            }
        }
        public static void Test()
        {
            string get_city = GetCityFromIPAddress();
            string ip_address = GetPublicIpAddress();
            string manufacture = GetManufacture();

            MessageBox.Show("Location : " +  get_city + "\nIP : " + ip_address + "\nManufacture : " + manufacture);
        }
    }
}
