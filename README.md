# Clube da Leitura

## Projeto

Desenvolvido durante o curso Fullstack da [Academia do Programador](https://www.academiadoprogramador.net) 2024

---
## Descri��o

Gustavo tem uma cole��o grande de revistas em quadrinhos. Por isso, resolveu
emprestar para os amigos. Assim foi criado o Clube da Leitura.

Mas para n�o perder nenhuma revista, seu pai contratou os alunos da Academia do
Programador 2024 para fazer uma aplica��o que cadastra as revistas e controla os
empr�stimos.

## Funcionalidades

1. O cadastro do **Amigo** consiste de:
	- nome
	- nome do respons�vel
	- telefone
	- endere�o

	```
	1. Os amigos t�m a possibilidade de receber Multas
	2. Visualizar amigos com Multas em aberto
	3. N�o pode emprestar para amigos que tem Multas em aberto
	4. Quitar Multas
	```

2. Para ter mais controle sobre a devolu��o das revistas, Gustavo quer ter a possibilidade de cadastrar Caixas de Revistas.
					
	Para cada **Caixa**, dever� ser cadastrado:

	- uma etiqueta
	- a cor da caixa
	- quantidade de Dias de Empr�stimo revistas
	- Ex: Caixa �Novidade� pode ser emprestada apenas por 3 dias

3. Para cada **Revista**, dever� ser cadastrado:
	- o t�tulo da revista
	- o n�mero da edi��o
	- o ano da revista
	- a caixa onde est� guardada


4. Para cada **Empr�stimo** cadastram-se:
	- o amigo que pegou a revista
	- qual foi a revista emprestada
	- a data do empr�stimo
	- a data de devolu��o
	- status indicando se foi conclu�do

	```
	1. Cada amigo s� pode pegar uma revista por empr�stimo.
	2. Mensalmente Gustavo verifica os empr�stimos realizados no m�s e diariamente os empr�stimos que est�o em aberto.
	3. Calcular data de Devolu��o baseando-se na Caixa da Revista
	4. Cobrar Multa para Devolu��es atrasadas
	```

5. Nossos amigos querem ter a possibilidade de cadastrar uma **Reserva** para as Revistas.
	- � v�lida apenas por 2 dias
	- Passados 2 dias ela expira
	- Mesmos campos do empr�stimo (amigo, revista)
	- A partir da tela de reservas, j� poder� fazer empr�stimos
	- status indicando se est� expirada