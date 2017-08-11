SELECT L.cod_lancamento, emissao, numero, fornecedores.nome  as favorecido, L.historico, IF(valor>=0, valor, 0) as deposito, IF(valor<0,valor,0) as pagamento, S.Soma AS Saldo
 FROM gf_Lancamentos AS L INNER JOIN fornecedores ON L.favorecido = fornecedores.fornecedor_id
  INNER JOIN (SELECT L2.cod_lancamento, SUM(L1.Valor) As Soma FROM gf_Lancamentos As L1 
  INNER JOIN gf_Lancamentos As L2 ON (L1.cod_lancamento<=L2.cod_lancamento And L1.conta=1) 
  GROUP BY L2.cod_lancamento) AS S 
ON L.cod_lancamento = S.cod_lancamento
WHERE L.conta = 1
ORDER BY L.cod_lancamento;