-- Script Date: 21/05/2023 23:36  - ErikEJ.SqlCeScripting version 3.5.2.94
CREATE TABLE [Despesa] (
  [IdDespesa] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ValorDespesa] real NOT NULL
, [TipoDespesa] text NOT NULL
, [FixaDespesa] bigint NOT NULL
, [QuantidadeParcelas] bigint NOT NULL
, [DataCriacaoDespesa] text NOT NULL
);
