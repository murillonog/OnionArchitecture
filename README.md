Onion Architecture
=================

# O que é a Onion Architecture?
Uma grande parte do projeto usual levanta questões básicas de acoplamento estreito e divisão de interesses. A Onion Architecture 
foi informada por Jeffrey Palermo por oferecer um método superior para construir aplicações no contexto de melhor testabilidade, 
praticidade e constância. A Onion Architecture atende às dificuldades enfrentadas pelas arquiteturas de 3 e n camadas e dá uma 
resposta para problemas normais. Camadas de design de cebola se associam umas às outras utilizando as interfaces.

# Camadas:
# Camada de Domínio
 Ela existe na parte central da arquitetura Onion, onde consiste em todas as entidades de domínio de aplicativo que nada mais 
são do que modelos de banco de dados criados pela abordagem do código em primeiro lugar. Neste projeto, usei a API Fluent na 
criação do esquema de tabela usando o Entity Framework.

# Camada de Repositório
 A camada de repositório atua como uma camada intermediária entre os serviços e objetos de modelo e nesta camada, manteremos 
todas as migrações de banco de dados e objeto de contexto de dados de aplicativo e nesta camada, normalmente adicionamos 
interfaces que consistirão em padrão de acesso a dados de leitura e gravar operações envolvendo um banco de dados.

# Camada de Serviços
 Esta camada é usada para a comunicação entre a camada do Repositório e o Projeto Principal, onde consiste em APIs exponíveis. A 
camada de serviço também pode conter a lógica de negócios para uma entidade. Nesta camada, as interfaces de serviço são mantidas 
separadas de sua implementação para acoplamento fraco e também a separação de interesses.

# Camada UI
 A IU nada mais é do que um aplicativo front-end que se comunicará com esta API.

# Prós e contras na Onion Architecture

## Vantagens:
As camadas da Onion Architecture são associadas por meio de interfaces. As implantações são feitas durante o tempo de execução;

A engenharia de aplicação é baseada no topo de um modelo de área;

Todas as dependências externas, semelhantes às chamadas de admissão e administração do conjunto de dados, são tratadas em camadas externas;

Sem condições da camada interna com camadas externas;

Os acoplamentos estão no meio;

Design adaptável, viável e conveniente;

Nenhuma razão convincente para fazer atividades normais e compartilhadas;

Pode ser tentado imediatamente, visto que o Application Center não depende de nada.

# Algumas desvantagens da Onion Architecture como segue:
 Difícil de compreender para amadores, incluindo a expectativa de absorver informações. Os modeladores geralmente confundem as obrigações de separação entre as camadas;
 
 Interfaces intensamente utilizadas.
