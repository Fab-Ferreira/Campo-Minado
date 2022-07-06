# Campo-Minado
## Introdução
Olá! Este programa trata-se de um joguinho de Campo Minado, onde o usuário deverá descobrir todos os campos seguros sem clicar nas bombas. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
&nbsp;

## Como funciona o jogo?
O usuário poderá escolher uma das três dificuldades: **fácil**, **médio** ou **difícil**. Dependendo da dificuldade escolhida, a quantidade de campos e a quantidade de bombas serão diferentes (100 campos com 20 bombas no modo fácil, 225 campos com 50 bombas no modo médio e 400 campos com 100 bombas no modo difícil).

Quando o usuário escolher a dificuldade, serão gerados os campos na tela e o usuário pode escolher qualquer um dos campos com o botão esquerdo do mouse. Ao escolher um campo, o campo irá mostrar um número, na qual indica a quantidade de bombas que há ao seu redor. Se o campo não indicar algum número, significa que não há bombas ao redor do campo clicado. Se aparecer o ícone de bomba, o usuário perde.

Ao clicar com um botão direito do mouse em um campo, o campo obterá a imagem de uma bandeira. O usuário poderá usar as bandeiras para indicar onde há uma bomba, porém a quantidade de bandeiras é limitada, pois a quantidade de bandeiras que podem ser usadas é a mesma da quantidade de bombas dentro do jogo.

Para vencer o jogo, você deve selecionar todos os campos seguros sem clicar em nenhuma bomba. Ao fazer isso, será mostrado uma mensagem na tela, avisando que você venceu o jogo. Você poderá reiniciar o jogo através do botão "Reiniciar" no canto direito da tela.

## Funcionalidade do Programa
Ao gerar os campos, o programa sorteia aleatóriamente 20, 50 ou 100 campos para se tornarem bombas, dependendo da dificuldade escolhida. Ao serem escolhidos, esses campos recebem o texto "Bomb".

Cada campo é nomeado de "campo" seguido de um número em ordem crescente, ou seja, o primeiro campo do jogo possui o nome de "campo0", em seguida vem o "campo1", e assim por diante. Ao selecionar o campo, o programa irá procurar quais são os 8 campos ao redor através do número em seu nome e efetuando as seguintes contas:

- **Posição Noroeste:** *nº no nome* - (*nº de colunas* + 1);
- **Posição Norte:** *nº no nome* - *nº de colunas*;
- **Posição Nordeste:** *nº no nome* - (*nº de colunas* - 1);
- **Posição Oeste:** *nº no nome* - 1;
- **Posição Leste:** *nº no nome* + 1;
- **Posição Sudoeste:** *nº no nome* + (*nº de colunas* - 1);
- **Posição Sul:** *nº no nome* + *nº de colunas*;
- **Posição Sudeste:** *nº no nome* + (*nº de colunas* + 1);

**Observação:** O nº de colunas varia de acordo com a dificuldade, sendo 10 colunas no fácil, 15 colunas no médio e 20 colunas no difícil.

Em variáveis *string*, será feita uma concatenação onde unificará o nome "campo" com o valor resultante de uma dessas posições e, após isso, o programa irá analisar quais dos campos com esses nomes possuem o texto "Bomb". A quantidade de campos ao redor com esse texto será mostrado no campo clicado.

Por exemplo: Ao clicar no campo de nome "campo48" no modo fácil, será guardado o número 48 para procurar os 8 campos ao redor.

- **Posição Noroeste:** 48 - (10 + 1) = 37;
- **Posição Norte:** 48 - 10 = 38;
- **Posição Nordeste:** 48 - (10 - 1) = 39;
- **Posição Oeste:** 48 - 1 = 47;
- **Posição Leste:** 48 + 1 = 49;
- **Posição Sudoeste:** 48 + (10 - 1) = 57;
- **Posição Sul:** 48 + 10 = 58;
- **Posição Sudeste:** 48 + (10 + 1) = 59;

Unindo esses números com o nome "campo", temos *campo37*, *campo38*, *campo39*, *campo47*, *campo49*, *campo57*, *campo58* e *campo59*. Após isso, será analisado qual dos 8 campos com esses nomes possuem o texto "Bomb" e, se possuir, será somado mais 1 para uma variável *int*, onde no final será mostrado no campo selecionado. Dependendo do valor desta variável, a cor do texto mudará.

Se o usuário clicar em um campo com o texto "Bomb", o programa irá inserir a figura da bomba em todos os campos com o mesmo texto e desativará todos os campos para que o usuário seja obrigado a reiniciar o jogo.

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.
