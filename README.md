![CR-3](https://github.com/user-attachments/assets/485b7ff1-c098-40bf-93b4-00058c8729a9)

## 🥁 CarnaCode 2026 - Desafio 03 - Factory Method

Oi, eu sou o Bruno e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio

No desafio **Factory Method** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:

- ✅ Boas Práticas de Software
- ✅ Código Limpo
- ✅ SOLID
- ✅ Design Patterns (Padrões de Projeto)

## Problema

Uma aplicação de e-commerce precisa enviar notificações por diferentes canais (Email, SMS, Push, WhatsApp) dependendo da preferência do cliente e tipo de notificação.
O código atual viola o Open/Closed Principle ao usar condicionais para criar notificações.

## Solução

A solução foi implementada utilizando o padrão **Factory Method** para desacoplar a lógica de criação das notificações da lógica de envio.

1.  **Criação da Interface `INotification`**:
    - Defini um contrato comum para todas as notificações.
    - Isso permite que o sistema trate Email, SMS, Push e WhatsApp da mesma forma (polimorfismo).

2.  **Implementação da Fábrica (`NotificationFactory`)**:
    - Centralizei a lógica de decisão em uma única classe responsável por instanciar os objetos.
    - Se for preciso adicionar um novo canal (ex: Telegram), altera-se apenas a fábrica, mantendo o restante do sistema intacto.

3.  **Refatoração das Classes Concretas**:
    - `EmailNotification`, `SmsNotification`, `PushNotification` e `WhatsAppNotification` agora implementam `INotification`.
    - Cada classe encapsula sua própria lógica de envio.

4.  **Desacoplamento do Cliente (`Program.cs`)**:
    - O código cliente não dá mais `new EmailNotification()`. Ele pede para a fábrica: `factory.Create(ENotificationType.Email)`.
    - Isso torna o código mais limpo, testável e fácil de manter.

### Exemplo de Uso

```csharp
var factory = new NotificationFactory();

// Criando uma notificação de Email sem saber os detalhes de implementação
INotification email = factory.Create(ENotificationType.Email);
email.SendOrderConfirmation("cliente@email.com", "12345");

// Criando uma notificação de SMS da mesma forma
INotification sms = factory.Create(ENotificationType.SMS);
sms.SendOrderConfirmation("+5511999999999", "12346");
```

## Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio

[Repositório Central do Desafio](https://github.com/b01tech/desafio-carnacode-2026-design-patterns.git)
