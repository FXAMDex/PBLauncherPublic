<?php
$host = 'localhost';
$database = 'your_db';
$username = 'postgres';
$password = 'your_dbpass';

$conn = pg_connect("host=$host dbname=$database user=$username password=$password");
if (!$conn) {
    echo "Gagal koneksi database: " . pg_last_error();
    exit;
}

function GenerateTokenPHP($length = 255) {
    $characters = '0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ/=+';
    $randomString = '';
    for ($i = 0; $i < $length; $i++) {
        $randomString .= $characters[rand(0, strlen($characters) - 1)];
    }
    return $randomString;
}

$login = 'nama_login'; // Validasi input
$token = GenerateTokenPHP();

$queryUpdate = "UPDATE accounts SET token = $1 WHERE login = $2";
$params = array($token, $login);

try {
    $result = pg_query_params($conn, $queryUpdate, $params);
    if ($result) {
        echo $token;
    } else {
        echo "Gagal update token: " . pg_last_error($conn);
    }
} catch (Exception $e) {
    echo "Error: " . $e->getMessage();
} finally {
    pg_close($conn);
}
?>