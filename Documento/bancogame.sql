SELECT `ranking`.`ID`,
    `ranking`.`Nome`,
    `ranking`.`Data`,
    `ranking`.`Pontuação`
FROM `gamerankings`.`ranking`;
UPDATE `gamerankings`.`ranking`
SET
`ID` = <{ID: }>,
`Nome` = <{Nome: }>,
`Data` = <{Data: }>,
`Pontuação` = <{Pontuação: }>
WHERE `ID` = <{expr}>;
DELETE FROM `gamerankings`.`ranking`
WHERE <{where_expression}>;
CREATE TABLE `ranking` (
  `ID` int(11) NOT NULL,
  `Nome` varchar(45) NOT NULL,
  `Data` date NOT NULL,
  `Pontuação` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
