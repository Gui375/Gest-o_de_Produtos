# Gestao_De_Produtos
Api criada do zero (Desenvolvimento Web - 4° Período Uniaraxá)

<h2>
  Questão 1:
  Em sala no início da disciplina criamos e comentamos que nossa API estava com muitas
  responsabilidades( regras de negócio , validações, persistência) , ferindo assim qual princípio?
  Descreva o princípio e o que a partir de então começamos a fazer para corrigir isso?
</h2>

<p>
  O princípio ferido é o "Princípio da Responsabilidade Única" (SRP), que afirma que uma classe deve ter apenas uma única responsabilidade. 
  Para corrigir isso, devemos dividir as responsabilidades em classes separadas, usar interfaces claras, testar unidades individualmente e documentar bem. 
  Isso torna o código mais organizado, manutenível e adaptável.
</p>
<br>
<br>
<h2>
  Questão 2:
  Começamos a dividir nosso projeto em camadas , são elas:
  Domain, Data, Applicaion e API. Descreva qual o papel de cada uma delas.
</h2>
<p>
  <ol>
    <li>Domain (Domínio): Contém entidades de negócios e regras de domínio.</li>
    <li>Data (Dados): Trata da persistência e recuperação de dados.</li>
    <li>Application (Aplicação): Lida com a lógica da aplicação e atua como intermediária entre a API e o domínio.</li>
    <li>API: Fornece interfaces para interagir com a aplicação a partir do exterior.</li>
  </ol>
</p>
<br>
<br>
<h2>
  Questão 3:
  Na camada de Domain criamos classes cujas propriedades são com set privado. Descreva,
  vantagem de usar dessa forma destacando como fizemos em sala com o produto.
</h2>
<p>
  A utilização de propriedades com set privado em classes de domínio oferece controle estrito sobre o estado dos objetos, 
  possibilitando validações, histórico de mudanças, garantia de integridade e encapsulamento, alinhando-se bem com as regras de negócios e prevenindo estados inválidos. 
  Na classe Produto, isso impede que o estado do objeto seja modificado diretamente de fora da classe, promovendo a consistência e a segurança dos dados.
</p>
<br>
<br>
<h2>
  Questão 4:
  Na camada de applicattion na classe service (de serviço) fizemos o que chamamos de injeção
  de dependência, descreva por que utilizamos essa técnica e como isso pode ser uma
  vantagem?
</h2>
<p>
  A injeção de dependência é uma técnica em que as dependências necessárias são fornecidas a uma classe em vez de criadas por ela. 
  Isso promove o desacoplamento, facilita os testes, melhora a manutenção e a reutilização de código, além de permitir a configuração externa das dependências, 
  tornando a aplicação mais flexível e adaptável.
</p>
