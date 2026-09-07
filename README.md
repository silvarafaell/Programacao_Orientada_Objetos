Curso Programação Orientada a Objetos no nextwave(LuisDEV)

### O que é
 - A Programação Orientada a Objetos, frequentemente abreviada como POO, é um paradigma de programação baseado no conceito de "objetos"
 - Em termos simples, um objeto é uma unidade dentro de um programa de software que representa um elemento ou entidade, podendo ser:
   - Real (como um carro ou pessoa)
   - Conceitual (como uma transação ou um processo)
 - Tema amplamente perguntado em entrevistas
 - Objetos têm dois principais componentes:
   - Atributos (ou Propriedades): Representam as características do objeto
     - Por exemplo, em um objeto representando um carro, os atributos poderiam incluir cor, marca, e modelo.
   - Métodos (ou Funções): Representam as ações que o objeto pode realizar
     - No caso do carro, os métodos poderiam incluir acelerar, frear e ligar o rádio
 - Importância
   - A Programação Orientada a Objetos (POO) é mais do que apenas um estilo ou paradigma de programação; é uma abordagem que moldou e influenciou a maneira como desenvolvemos, entendemos e organizamos software
   - Uma das principais vantagens da POO é que ela se alinha com a forma como muitas pessoas percebem e categorizam o mundo ao seu redor: por meio de objetos e interações.
     - Isso permite que os desenvolvedores representem entidades e conceitos do mundo real (como pessoas, carros, transações bancárias) de forma intuitiva
   - Entre outras vantagens estão:
     - Reusabilidade de Código
     - Encapsulamento e Proteção de Dados
     - Flexibilidade
     - Manutenção e Refatoração Simplificadas
     
### Classes e Objetos
 - O que são
   - Dentro do universo da POO, os conceitos de classes e objetos são fundamentais
   - Esses conceitos são bem próximos e interligados
   - As classes podem ser vistas como um modelo para criar objetos
   - Ela define o que os objetos terão:
     - Atributos (frequentemente chamados de campos ou propriedades)
     - Comportamentos (métodos)
   - Um objeto é uma instância concreta de uma classe
   - Instância refere-se ao processo de criação de um objeto a partir de uma classe
   - Quando instanciamos uma classe, estamos, na verdade, reservando um espaço na memória para um novo objeto e retornando uma referência a esse objeto
   - Se uma classe é o modelo, o objeto é a construção real baseada nele
   - Em C#, o operador new é usado para criar uma instância (ou objeto) de uma classe

### Herança
 - O que é
   - Herança é um dos quatro pilares fundamentais da Programação Orientada a Objetos, juntamente com Encapsulamento, Polimorfismo e Abstração
   - Ela permite que novas classes adquiram propriedades e comportamentos de classes já existentes, promovendo reutilização de código e organização hierárquica.
   - A ideia central da herança é que você pode criar uma nova classe com base em uma classe já existente
   - A classe já existente é chamada de classe base ou classe pai, e a nova classe é referida como classe derivada ou classe filha
   - Em C#, a herança está limitada a uma única classe
   - Benefícios
     - Reutilização de Código: Evita a redundância, pois permite que a classe filha reutilize atributos e métodos já definidos na classe pai
     - Representação Hierárquica: Facilita a representação de relações do tipo "é um". Por exemplo, se dissermos que "Um Cliente é uma pessoa", a classe Cliente poderia herdar da classe Pessoa
     - Extensibilidade: A classe derivada pode não apenas herdar características da classe base, mas também pode ter novos atributos e métodos ou sobrescrever os herdados
     
### Encapsulamento
 - O que é
   - Encapsulamento é a técnica de ocultar detalhes internos de uma classe e expor apenas o necessário, garantindo a integridade dos dados e a organização do código
   - Isso evita que partes externas do programa alterem o estado interno de um objeto de maneiras inesperadas.
   - Benefícios
     - Proteção de Dados: Evita que dados sejam modificados inadvertidamente ou de forma mal-intencionada
     - Flexibilidade e Manutenção: Permite que os desenvolvedores alterem a implementação interna de uma classe sem afetar outras partes do programa que usam essa classe
     - Abstração: Oculta a complexidade, mostrando apenas as operações relevantes
   - Modificadores de Acesso
     - O encapsulamento em C# é implementado usando modificadores de acesso. Estes definem o nível de acesso a membros de uma classe:
       - public: O membro pode ser acessado de qualquer parte do código
       - private: O membro só pode ser acessado dentro da mesma classe. Este é o padrão para membros de classe se nenhum acesso for especificado
       - protected: O membro pode ser acessado dentro da mesma classe e por classes derivadas.
       - internal: O membro pode ser acessado apenas dentro do mesmo assembly
       - protected internal: Combinação de protected e internal; o membro pode ser acessado dentro do mesmo assembly e por classes derivadas


