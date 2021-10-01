# Consumo API IBPT - De Olho No Imposto
 
Requisição API IBPT

Aaron de Carvalho Balbino 
Contato: carvalhosins@gmail.com


Sumário:

1.	Estrutura
2.	Requisição 
3.	Implementação
4.	Instruções para Execução

Introdução:
Este programa foi desenvolvido em WidnowsForms utilizando a linguagem C#.
O mesmo parte de um princípio em que se tem uma base de dados existente onde podem ser retornados todos os códigos de produtos, a partir disso a requisição é feita linha a linha atualizando um objeto que irá preencher uma tabela temporária que posteriormente será chamada através de uma procedure para atualização da base de dados.

## 1 – Estrutura
  

Botões Principais da Aplicação:
- Botão Retornar Produtos: Realiza uma chamada no banco na tabela CalculoImpostos e preenche o grid com seus dados.
- Botão Atualizar: Realiza a chamada na API para todos os produtos da tabela e preenche a tabela temporária.
- Botão Rodar Procedure: Este botão é habilitado uma vez que a atualização na tabela temporária é concluído,  este faz com que a Procedure PR_AtualizaTabelasIBPT seja executada.
- Botão Limpar: Realiza a limpeza da visualização do grid.


## 2 – Requisição
No projeto as classes cApi e ParametrosAPI ficam responsáveis por realizar a requisição.
Para que a requisição seja feita deve ser passar como parâmetro a classe de ParametrosAPI, nesta classe temos as seguintes variáveis do tipo REQUIRED para a API:
``` c#
public string Token { get; set; }
public string Cnpj { get; set; }
public string Codigo { get; set; }
public string Uf { get; set; }
public int Ex { get; set; }
```

Exemplo da montagem da classe, note que as variáveis Token e CNPJ são fixadas com um valor já atribuído.
 

## 3 – Implementação

Foram criadas duas classes base para a tratar os dados retornados pela API, sendo estas:

- ProdutoIBPT: Contém as funções de atualização e inserção na tabela do banco assim como o método que povoa a lista de ProdutoIBPTDTO para inserção no banco.
- ProdutoIBPTDTO: Carrega somente os campos de interesse para a inserção na tabela temporária.
- ListaProdutoIBPT: Contém o método CarregarTodos() que povo um DataSet com a tabela CalculoImposto.


## 4 - Instruções para Execução

O  programa é bem intuitivo e a lógica abaixo deve ser seguida para seu uso coreto:
o 1 – Retornar os produtos para povoar a tabela.
o 2 – Atualizar para realizar a chamada da API e povoar a tabela temporária.
o 3 – Rodar a Procedure para povoar a tabela principal.

OBS: O botão de rodar a procedure só estará visível após a atualização ser feita.


## Autor

- [@AaronCrvl](https://www.github.com/AaronCrvl)

  
