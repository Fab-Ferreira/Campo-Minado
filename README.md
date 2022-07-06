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

Cada campo é nomeado de "campo" seguido de um número em ordem crescente, ou seja, o primeiro campo do jogo possui o nome de "campo0", em seguida vem o "campo1", e assim por diante.
