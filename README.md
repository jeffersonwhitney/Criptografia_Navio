## Análise e Documentação do Código

## Como usar
1. **Baixe o arquivo .rar:** Instale o setup e abra o executavel ou siga para as intruções abaixo.
2. **Compile o código:** Utilize seu ambiente de desenvolvimento C# para compilar o projeto.
3. **Execute o programa:** Execute o arquivo executável gerado.
4. **Interaja com o menu:** Siga as instruções no console para realizar as operações desejadas.

### Objetivo Geral
O código apresentado implementa um simples sistema de descriptografia, especificamente projetado para um tipo de criptografia customizada, onde os últimos dois bits de cada byte são invertidos e os primeiros quatro bits são trocados com os quatro seguintes. A aplicação oferece uma interface de linha de comando (CLI) para que o usuário possa inserir a mensagem criptografada e obter a versão descriptografada.

### Preview do Código em Excecução
![image](https://github.com/user-attachments/assets/56618861-b28a-494e-ba73-e0c05ef02d11)

### Estrutura do Código
* **Namespace:** ConsoleApp1: Contém a classe principal do programa.
* **Classe:** Program:
    * **Método Main:** Ponto de entrada do programa.
        * Cria um loop para permitir múltiplas descriptografias.
        * Oferece ao usuário a opção de descriptografar uma mensagem ou sair do programa.
        * Chama o método Descriptografia para realizar a descriptografia.
    * **Método Descriptografia:**
        * Recebe a mensagem criptografada como entrada.
        * Remove todos os espaços da mensagem.
        * Inverte os últimos dois bits de cada byte.
        * Troca os primeiros quatro bits com os quatro seguintes em cada byte.
        * Converte cada byte binário para um caractere e exibe a mensagem descriptografada.

### Descrição Detalhada do Código
* **Regex.Replace:** Remove todos os espaços da mensagem criptografada, garantindo que apenas os bits sejam processados.
* **Loops e índices:** Os loops for são utilizados para iterar sobre cada byte da mensagem, realizando as operações de inversão e troca de bits.
* **Conversão de binário para caractere:** A função Convert.ToInt32(temp, 2) converte a representação binária de um byte para um número decimal. Em seguida, o casting para char converte esse número para o caractere correspondente.
