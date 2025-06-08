<?php
$ingredient = '/x!a@r-$r%an¨.&e&+f*f(f(a)';
$password = $_POST['password'];

$hashedPassword = hash_hmac('md5', $password, $ingredient);

echo $hashedPassword;
?>