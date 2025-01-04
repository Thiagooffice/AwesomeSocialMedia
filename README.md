# AwesomeSocialMedia 👥

Bem-vindo ao repositório do AwesomeSocialMedia, um projeto desenvolvido em .NET que implementa uma rede social utilizando arquitetura de microsserviços. Este README fornece as informações sobre o projeto.

## 📋 Sobre o Projeto

O objetivo desse projeto é desenvolver uma plataforma de rede social escalável e modular, baseada em uma arquitetura de microsserviços, que permita aos usuários interagir de forma dinâmica e personalizada, ao mesmo tempo garantindo alta disponibilidade, desempenho e facilidade de manutenção. 

**Estrutura do projeto:**

- **Users:** Gerencia o perfil e os dados dos usuários da plataforma.
- **Posts:** Realiza a criação, atualização, exclusão e consulta de postagens.
- **Newsfeed:** Gera um feed de notícias personalizado com base nas postagens de usuários seguidos.
- **Social Graph:** Mantém e gerencia as relações sociais na plataforma, como conexões e seguidores.
- **Observability:** Implementa o monitoramento da API, garantindo desempenho, disponibilidade e confiabilidade por meio de métricas e visualizações.

**Abaixo temos o diagrama com a arquitetura do projeto** ⬇️

<div align="center">
  <img src="https://github.com/user-attachments/assets/553e6843-95bd-41b4-bd8b-30e6c298a588" alt="imgSocialMedia">
</div>

## 🛠 Tecnologias e Práticas utilizadas

- API desenvolvida com .NET 7
- Microsserviços
- Domain-Driven Design
- CI/CD
- Azure Devops
- Docker
- Service Discovery Ocelot
- Arquitetura Limpa
- Injeção de Dependência
- CQRS
- Mediator Pattern
- Entity Framework Core
- Padrão Repository
- FluentValidation
- Testes Unitários
- xUnit
- RabbitMQ
- Consul API Gateway
- Prometheus
- Grafana
- SQL Server

Essas tecnologias foram escolhidas para garantir um desenvolvimento ágil, robusto e escalável.

---

## Ocelot
O Ocelot é uma biblioteca para .NET que facilita a construção de gateways de API em microserviços.
Ele funciona como um ponto de entrada único para solicitações de clientes, oferecendo funcionalidades como **roteamento, 
balanceamento de carga, cache e autenticação**, simplificando a **comunicação** entre serviços em arquiteturas distribuídas. 
Para integrar o Ocelot em projetos .NET, você precisa utilizar o seguinte pacote: **Ocelot**.

![1_6PIvXjt_3phsOun3ieHh8g](https://github.com/Thiagooffice/AwesomeShop/assets/84478212/3f3bb492-0d33-4f5b-9ed7-c358f147465a)

---

## Azure Devops
O Azure DevOps é uma plataforma de desenvolvimento colaborativo da Microsoft que oferece um conjunto de ferramentas para o gerenciamento de ciclo de vida de software. Ela inclui recursos como **controle de versão, integração contínua, entrega contínua (CI/CD), gerenciamento de projetos, e colaboração em equipes**. 
O Azure DevOps é amplamente utilizado para automatizar o fluxo de trabalho de desenvolvimento, testar e implantar aplicações em ambientes de produção, proporcionando uma gestão eficiente de projetos e um ciclo de vida de software ágil e seguro.

Para integrar o Azure DevOps em projetos, você pode usar as seguintes ferramentas e pacotes:

- Azure DevOps Services para CI/CD e gerenciamento de projetos.
- Azure Pipelines para automação de build e release.
- Azure Repos para controle de versão.
  
![azure_devops-1](https://github.com/user-attachments/assets/15f9e461-92ac-44aa-a88b-7aacb4401bae)


---

## Consul API Gateway
O Consul é uma ferramenta poderosa para descoberta de serviços e gerenciamento de configuração distribuída em arquiteturas de microserviços. Ele permite que serviços se registrem e
sejam localizados dinamicamente por outros serviços, eliminando a necessidade de configuração manual. Entre suas principais funcionalidades estão **registro de serviços, detecção automática, 
verificação de saúde, e DNS integrado,** simplificando a comunicação e garantindo resiliência em sistemas distribuídos.

Os pacotes a serem utilizados são:

~~~ csharp
Consul.Client
Winton.Extensions.Configuration.Consul
Ductus.FluentDocker
~~~

  ![344902257-6b3441cc-078a-41d9-9f8f-6ac66bdd8b1a](https://github.com/user-attachments/assets/341479d5-8705-4bbb-b43e-822615252fdc)

  
---

## RabbitMQ
O RabbitMQ é um sistema de mensageria amplamente utilizado para **fila de mensagens, roteamento de mensagens, tolerância a falhas e comunicação assíncrona** em arquiteturas distribuídas. 
Ele permite que sistemas e serviços troquem informações de maneira confiável e escalável, reduzindo o acoplamento entre eles. Com suporte a múltiplos protocolos e fácil integração com o .NET, 
o RabbitMQ é uma solução robusta para implementar padrões como pub/sub, fila de trabalho e roteamento direto.

Os pacotes a serem utilizados são:

~~~ csharp
RabbitMQ.Client
EasyNetQ
MassTransit
~~~

![344899539-eb187ffc-2516-40ab-8db6-b61a9dba632b](https://github.com/user-attachments/assets/ef16bb0d-883c-4a6a-b84b-965e8dc44817)

  
---

## Prometheus
O Prometheus é uma poderosa ferramenta de monitoramento e alertas para sistemas distribuídos. Ele coleta métricas de aplicações e serviços em tempo real, 
armazenando-as em um banco de dados baseado em séries temporais. Suas principais funcionalidades incluem **coleta eficiente de métricas, consulta avançada com PromQL, alertas configuráveis** e 
integração com uma ampla gama de sistemas. O Prometheus é amplamente utilizado para garantir visibilidade e desempenho em arquiteturas modernas de microserviços.

Os pacotes a serem utilizados são:

~~~ csharp
Prometheus.Client  
Prometheus.AspNetCore  
~~~

![image](https://github.com/user-attachments/assets/2672e037-6c6d-4de7-a95f-ea72e633c9d9)

  
---

## Grafana
O Grafana é uma ferramenta de visualização e análise de dados que permite criar **painéis interativos, monitoramento em tempo real, e alertas configuráveis** a partir de várias fontes de dados. 
Ele é amplamente utilizado em conjunto com sistemas como **Prometheus, ElasticSearch e InfluxDB** para fornecer insights detalhados sobre o desempenho e o estado de aplicações e infraestruturas. 
Com suporte para personalização e extensibilidade, o Grafana é essencial para arquiteturas modernas que necessitam de monitoramento eficiente.

Os passos básicos para integrar o Grafana em seu ambiente incluem:

1. Configurar uma fonte de dados (ex.: Prometheus).
2. Criar ou importar painéis de visualização.
3. Configurar alertas para monitoramento proativo.

![image](https://github.com/user-attachments/assets/b1d0451c-8083-4c0c-98d9-a86d81c9e6f3)

---

## 🤝 Colaboradores

<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Thiagooffice">
        <img src="https://avatars.githubusercontent.com/u/84478212?s=400&u=b003ad011d6337bf4a03b4aadde3d905bca5c9b8&v=4" width="160px;" alt="Photo by Thiago Leal on GitHub"/><br>
        <sub>
          <b>Thiago Leal de Souza</b>
        </sub>
      </a>
    </all>
  </tr>
</table>

---

<a href="#top">Voltar ao topo</a> ⬆️
