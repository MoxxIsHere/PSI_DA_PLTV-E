# Projecto de Desenvolvimento de Aplicações

## Índice

- [Projecto de DA](#projecto-de-desenvolvimento-de-aplicações)
	- [Índice](#índice)
- [Instalação](#instalação)
	1. [Requerimentos](#requerimentos)
	2. [Criação da Base de Dados](#criação-da-base-de-dados)
	3. [Compilação](#compilação)
- [Execução](#execução)
	1. [Localizar o Executável](#localizar-o-executável)

# Instalação

## Requerimentos

- **Sistema Operativo Windows** (WindowsXP, Windows Vista, Windows 10, Windows11)
- **Visual Studio [2016 - 2022]**
- **dotNet Framework** (vem com o Visual Studio)

## Criação da Base de Dados

Criar uma pasta chamada "BaseDados" na ***root*** do Disco Local **C**, o caminho deve ficar "***C:\BaseDados\\***"

![instrucao1](https://media.discordapp.net/attachments/813165924533927966/989305269647470652/unknown.png)

Com o **Visual Studio**, executar a geração da base de dados a partir do modelo **Model1.edmx**, que se encontra na mesma pasta que este ficheiro, clicando no fundo de ecrã do editor, e escolhendo "**Generate Database from Model...**"

![instrucao2](https://media.discordapp.net/attachments/977145596727156746/989307379202007080/unknown.png)

![instrucao3](https://media.discordapp.net/attachments/977145596727156746/989308209628082236/unknown.png)

Na nova janela do **Visual Studio**, clique no botão "**New Connection...**"

![instrucao4](https://media.discordapp.net/attachments/977145596727156746/989308683127226439/unknown.png)

E clique no botão "**Change...**", na nova janela selecione "**Microsoft SQL Server Database File**" e clique "**OK**", depois clique no botão "**Browse...**" e crie um ficheiro chamado "**dadb.mdf**" na pasta que criou no primeiro passo com o caminho final "***C:\BaseDados\dadb.mdf***" 

![instrucao5](https://media.discordapp.net/attachments/977145596727156746/989308972098023466/unknown.png)

![instrucao6](https://media.discordapp.net/attachments/977145596727156746/989308852845568070/unknown.png)

No fundo da janela, dê *tick* à check box que diz "**Save connection settings in App.Config as:**" e verifique que a caixa de texto diz "**Model1Container**" e clique "**Next >**" e depois clique "**Finish**"

![instrucao7](https://media.discordapp.net/attachments/977145596727156746/989309139123593226/unknown.png)

![instrucao8](https://media.discordapp.net/attachments/977145596727156746/989309370284253234/unknown.png)

Um novo separador vai abrir, isto pode demorar até um minuto dependente do computador, depois do  texto carregar, clique na seta verde no canto superior direito do separador, na nova janela clique em "**Local**" e selecione "**MSSQLLocalDB**", e ao fundo da janela selecione **"Database Name: C:\BASEDADOS\DADB.MDF**" e clique "**Connect**"

![instrucao9](https://media.discordapp.net/attachments/977145596727156746/989318585165951007/unknown.png)

![instrucao10](https://media.discordapp.net/attachments/977145596727156746/989321014070640650/unknown.png)

Após a execução pode fechar os separadores abertos no **Visual Studio**

## Compilação

Pressione **CTRL+ALT+L**, selecione "**ProjectodeDA.sln**" e clique duas vezes

![instrucao11](https://media.discordapp.net/attachments/977145596727156746/989323991221174352/unknown.png)

Pressione **CTRL+SHIFT+B** e espere uns segundos, quando disser "*Build Succeeded*" pode fechar o **Visual Studio**

![instrucao12](https://media.discordapp.net/attachments/977145596727156746/989325355896668181/unknown.png)

# Execução

## Localizar o Executável

O executável chama-se **ProjectodeDA.exe** e encontra-se no directório "***\bin\Debug\\***"

![instrucao13](https://media.discordapp.net/attachments/977145596727156746/989326938810224640/unknown.png)

![instrucao14](https://media.discordapp.net/attachments/977145596727156746/989326886029111336/unknown.png)

[**Regressar ao Topo**](#projecto-de-desenvolvimento-de-aplicações)
