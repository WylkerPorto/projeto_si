<?php
	$host = "localhost";
	$db   = "game_si";
	$user = "root";
	$pass = "";
	// conecta ao banco de dados
	$con = mysql_pconnect($host, $user, $pass) or trigger_error(mysql_error(),E_USER_ERROR); 
	// seleciona a base de dados em que vamos trabalhar
	mysql_select_db($db, $con);
	// cria a instrução SQL que vai selecionar os dados
	//$query = sprintf("INSERT INTO ranking(Nome, Data, Pontuacao) VALUES ('teste2', NOW(), 35)");
	$nome = $_GET['Nome'];
	$pontos = (int)$_GET['Pontos'];
	$query = sprintf("INSERT INTO ranking(Nome, Data, Pontuacao) VALUES ('$nome', NOW(), '$pontos')");
	// executa a query
	$inserir = mysql_query($query, $con) or die(mysql_error());
	if($inserir)
		echo("1");
	else
		echo("0");
?>