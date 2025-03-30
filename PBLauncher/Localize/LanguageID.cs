using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBLauncher.Localize
{
    public class LanguageID : IStrings
    {
        public string LOADING { get; set; } = "Memuat...";
        public string EXIT_ASK { get; set; } = "Apakah anda yakin ingin menutup Program ini?";
        public string CHECK_IMPORTANT_FILES { get; set; } = "Memeriksa folder sementara...";
        public string GAME_RUNNING { get; set; } = "Sudah ada program Game yang berjalan";
        public string LAUNCHER_RUNNING { get; set; } = "Sudah ada Launcher yang terbuka/berjalan";
        public string CONNECTING_TO_SERVER { get; set; } = "Memeriksa Koneksi Ke Server...";
        public string SERVER_CONNECTION_UNKNOWN { get; set; } = "Tidak dapat menghubungkan ke Server.\nLauncher akan Ditutup";
        public string CHECK_LAUNCHER_UPDATE { get; set; } = "Memeriksa Versi terbaru..";
        public string LAUNCHER_UPDATE_ERROR { get; set; } = "Terdapat kesalahan saat Mendownload Launcher terbaru!";
        public string SERVER_UNKNOWN_PACKAGE { get; set; } = "Sesuatu ada yang salah...\nKontak bantuan:\nSpacegrid Group";
        public string AUTH_LOGIN { get; set; } = "Mencoba Masuk, Tunggu sebentar...";
        public string AUTH_ACC_NO_STAFF { get; set; } = "Login Hanya bisa dimasuki oleh staff saja.";
        public string AUTH_ACC_BANNED { get; set; } = "Launcher kamu sudah di banned Selamanya.";
        public string AUTH_ACC_CREAT_ERROR { get; set; } = "We were unable to create your user on the server,\nyou are creating accounts too fast!";
        public string AUTH_ACC_NULL { get; set; } = "Unable to find your username on server.\nContact support for more information!\nprivatepointblank.com/suporte";
        public string CHECK_SERVER_STATUS { get; set; } = "Memeriksa status server...";
        public string SERVER_MAINTENANCE { get; set; } = "Game Saat ini sedang dalam Perbaikan.\nSilahkan Coba Lagi!";
        public string DOWNLOAD_USERLIST { get; set; } = "Mendownload UserFileList: ";
        public string DOWNLOAD_LAUNCHER_UPDATE { get; set; } = "Mengunduh Update: ";
        public string DOWNLOAD_USERLIST_ERROR { get; set; } = "Terjadi kesalahan saat mencoba mengunduh UserFileList.";
        public string DELET_TRASH { get; set; } = "Menghapus file yang tidak berguna...";
        public string EXTRACT_FILE_UPDATE { get; set; } = "Mengekstrak dan menginstall file update...";
        public string EXTRACT_FILE { get; set; } = "Mengekstrak files...";
        public string FILE_CHECK_GET { get; set; } = "Updating GAME SHIELD, please wait...";
        public string ACCESS_DENIED { get; set; } = "Access denied";
        public string BAN_TIME_LEFT { get; set; } = "Time left: {0}Days {1}Hours {2}Minutes {3}Seconds";
        public string GAME_NOT_AVAILABLE { get; set; } = "The game is not available at the moment.";
        public string UPDATE_REC { get; set; } = "Perbaharui game anda sekarang.";
        public string GAME_IS_UPDATE { get; set; } = "Game sudah versi terupdate!";
        public string FILE { get; set; } = "File";
        public string TOTAL { get; set; } = "Total";
        public string CHECK_REC { get; set; } = "Invalid files detected. Verify Customer Integrity!";
        public string LARGER_VERSION { get; set; } = "Versi client terlalu besar dengan server.\nCobalah untuk mengupdate Ulang!";
        public string DOWNLOAD_FILE { get; set; } = "Mengunduh files...";
        public string DOWNLOAD_FILE_ERROR { get; set; } = "Terjadi kesalahan ketika mengunduh file [{0}].\nCoba Lagi!";
        public string CHECKING_FILES { get; set; } = "Memeriksa game files...";
        public string CHECK_ERROR { get; set; } = "An error occurred while trying to verify client files!";
        public string CONFIG_ERROR { get; set; } = "Tidak dapat menemukan\nKonfigurasi game.";
        public string CONNECTION_LOST { get; set; } = "Koneksi server bermasalah .";
        public string LOADING_PRE_START { get; set; } = "Loading GAME SHIELD...";
        public string GAME_NOT_FOUND { get; set; } = "Tidak dapat menemukan PointBlank.exe";
        public string START_ERROR { get; set; } = "Tidak dapat memulai game.\nServer mengatakan kunci masuk tidak sah.";
        public string USERLIST_ERROR { get; set; } = "terjadi kesalahan saat memeriksa UserFileList.dat file.";
        public string GET_UPDATE_INFO { get; set; } = "Mendapatkan informasi Update server...";
        public string GET_UPDATE_ERROR { get; set; } = "Terjadi kemungkinan error saat memeriksa update.";
        public string TOP_INFO { get; set; } = "Launcher: {0}\nPoints: {1}";
        public string CORE_NOTFOUND { get; set; } = "Launcher_core.dll tidak ditemukan.";
        public string WRONG_ID_PASSWORD { get; set; } = "Username Atau Password tidak sesuai";
        public string ID_PASSWORD_NULL { get; set; } = "Username atau Password harus di isi!";
        public string CLICK_LOGIN { get; set; } = "Click Login Untuk Melanjutkan";
        public string MAINTENANCE_FEATURE { get; set; } = "Fitur Ini Sedang Dalam Pengembangan";
    }
}
