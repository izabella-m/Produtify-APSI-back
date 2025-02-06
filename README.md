*Caso de uso - Produtify (Back-end)*

  A plataforma de e-commerce Produtify precisa de um sistema para gerenciar o cadastro de produtos, pedidos, estoque e relatórios de vendas. Este documento descreve o caso de uso para o cadastro de um produto por um vendedor.

*Caso de uso:* Cadastrar Produto (CSU01)

*Sumário:* O vendedor usa o sistema para cadastrar um novo produto na plataforma

*Atores:*
  Primário:  Vendedor
  Secundários:  Equipe de Moderação

*Fluxo Principal:*
  - O vendedor acessa a opção de cadastrar um novo produto.
  - O sistema solicita as informações do produto, incluindo nome, descrição, preço, quantidade em estoque e categoria.
  - O vendedor preenche as informações e define o valor de desconto, se aplicável (conforme RN13).
  - O sistema verifica se a quantidade em estoque é maior ou igual ao estoque mínimo configurado (conforme RN01).
  - Se o produto for regulamentado, o sistema solicita a documentação exigida para aprovação (conforme RN03).
  - O vendedor envia o cadastro para revisão.
  - O sistema envia a solicitação para a equipe de moderação para análise.
  - Após a aprovação da equipe de moderação, o produto é publicado na plataforma, e o caso de uso termina.


