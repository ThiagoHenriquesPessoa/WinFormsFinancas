-- Script Date: 05/06/2023 22:03  - ErikEJ.SqlCeScripting version 3.5.2.94
CREATE TABLE [Despesa] (
  [IdDespesa] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
, [ValorDespesa] real NOT NULL
, [TipoDespesa] text NOT NULL
, [QuantidadeParcelas] bigint NOT NULL
, [ParcelaAtual] bigint NOT NULL
, [DataCriacaoDespesa] text NOT NULL
, [DataVencimentoDespesa] text NOT NULL
, [DespesaPaga] bigint NOT NULL
, [FormaPagamento] text NOT NULL
);
