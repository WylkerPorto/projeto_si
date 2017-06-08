<?php
// Mensagens de Erro
$msg[0] = "Conexão com o banco falhou!";
$msg[1] = "Não foi possível selecionar o banco de dados!";

// Fazendo a conexão com o servidor MySQL
$conexao = mysql_pconnect("mysql.hostinger.com.br","u325795122_root","rootgame1") or die($msg[0]);
mysql_select_db("Bancogamecerto",$conexao) or die($msg[1]);

// Colocando o Início da tabela
?>
<table border="1"><tr>
   <td><b>Posição</b></td>
   <td><b>Nome</b></td>
   <td><b>Pontuação</b></td>
</tr>
<?

// Fazendo uma consulta SQL e retornando os resultados em uma tabela HTML
$query = "SET @posicao:=0; SELECT @posicao:=@posicao+1 AS posicao,Nome,P
FROM tb_corrida
ORDER BY Pontuacao desc;";
$resultado = mysql_query($query,$conexao);
while ($linha = mysql_fetch_array($resultado)) {
   ?>
   <tr>
      <td><? echo $linha['posicao']; ?></td>
      <td><? echo $linha['nome']; ?></td>
      <td><? echo $linha['pontuacao']; ?></td>
   </tr>
   <?
}
?>
</table>
?>
