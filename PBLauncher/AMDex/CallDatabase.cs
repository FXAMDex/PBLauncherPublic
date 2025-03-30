using Npgsql;
using PBLauncher.Login;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher.AMDex
{
    public class CallDatabase
    {
        public static class DBConfig
        {
            public static string DBCallConfig = "Host=167.172.79.41;Database=v316;Username=postgres;Password=spacegrid2025;";
        }
        public static async Task ValidateDevice()
        {
            string connectionString = DBConfig.DBCallConfig.ToString();
            string query = "SELECT reason, date_end FROM get_banned_device WHERE ip_address = @ip AND mac_address = @mac_address";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ip", AMDexCustom.GetPublicIpAddress());
                    cmd.Parameters.AddWithValue("@mac_address", AMDexCustom.GetPublicIpv6Address());
                    await conn.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            string reason = reader["reason"].ToString();
                            DateTime dateEnd = Convert.ToDateTime(reader["date_end"]);

                            if (dateEnd < DateTime.Now)
                            {
                                // Hak Akses Kembali Ketika Tanggal Sudah Terlewati
                                return;
                            }
                            else
                            {
                                MessageBox.Show($"Komputer Anda Telah Di Banned.\n\nAlasan : {reason}\nBanned End : {dateEnd.ToString("dd MMMM yyyy")}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Application.Exit();
                            }
                        }
                        else
                        {
                            // IP tidak ditemukan, izinkan akses
                            return;
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Kesalahan database: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan umum: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static async void GetInfoPCCafe()
        {
            string connectionString = DBConfig.DBCallConfig.ToString();
            string query = "SELECT date_end FROM info_icafe_data WHERE ip_icafe = @ip_icafe";

            try
            {
                using (var conn = new NpgsqlConnection(connectionString))
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ip_icafe", AMDexCustom.GetPublicIpAddress());
                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            DateTime dateEnd = Convert.ToDateTime(reader["date_end"]);

                            if (dateEnd < DateTime.Now)
                            {
                                // Tanggal kadaluarsa telah lewat
                                MessageBox.Show("Tanggal kadaluarsa telah lewat. Silakan hubungi administrator.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Tanggal kadaluarsa belum lewat
                                // Lakukan aksi yang diinginkan
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Kesalahan database: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kesalahan umum: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
