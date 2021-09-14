# hegChatRoom

**Conteúdo:**
- [O que é o hegChatRoom?](#O-que-é-o-hegChatRoom)
- [Funcionalidades](#Funcionalidades)
- [Testes Unitários](#MSTest/NUnit)
- [Como Usar](#Como-Usar)

# O que é o hegChatRoom?

hegChatRoom é um aplicativo .NET Core simples, que permite a comunicação com outros ususuários por meio do console e do protocolo TCP.

# Funcionalidades

## Lado Servidor

O servidor possui informações sobre cada cliente, e quando conectado, recebe os dados do cliente.

## Lado Cliente

Os clientes se conectam so servidor e se comunicam apenas por meio dele. Eles não sabem nada um do outro, o que permite maior anonimato. O Servidor fornece a cada cliente seu endereço ID exclusivo uma vez durante a conexão, que é usado posteriormente para identificação.

### Opção do Console

|Comando|Descrição|
|--|--|
|**exit**|Sair a qualquer momento do Chat|

# Testes MSTest/NUnit

Foi criado teste unitário de funcionalide específica do projeto, usando ambas ferramentas que proporcionam esta operação.

# Como Usar?

Ambos os lados (Servidor/Cliente) chamados de **Server** e **Client** respectivamente, podem ser executados diretamente na linha de comando do ambiente operacional na qual for compilado. E o caminho onde os mesmos são criados segue o PATH do projeto seguindo ../bin/release.
