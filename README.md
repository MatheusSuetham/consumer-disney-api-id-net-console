# Consumer Disney ID API - .NET Console

Aplicação console desenvolvida em C#/.NET para consumir a Disney API e exibir informações de um personagem específico.

## Endpoint utilizado

```text
https://api.disneyapi.dev/character/423
```

O identificador `423` corresponde ao personagem **Big Bad Wolf**.

## Funcionamento

A aplicação realiza uma requisição HTTP para a Disney API, interpreta o JSON retornado e exibe no console:

- Nome do personagem
- URL da imagem do personagem

Exemplo de saída:

```text
Nome:
Big Bad Wolf

Imagem:
https://static.wikia.nocookie.net/disney/images/7/73/The_Big_Bad_Wolf.png
```

## Tecnologias utilizadas

- C#
- .NET 8
- HttpClient
- System.Text.Json

## Como executar

Entre na pasta do projeto:

```bash
cd ConsumerDisneyIdApi
```

Execute:

```bash
dotnet run
```

## Atividade

Exercício de Desenvolvimento Web - consumo da Disney API utilizando aplicação console em C#/.NET.
