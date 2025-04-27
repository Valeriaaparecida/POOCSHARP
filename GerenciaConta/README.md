# Sistema de Gerenciamento de Conta Bancária

## Requisitos do Sistema

Em um banco, para se cadastrar uma conta bancária, é necessário informar:

- **Número da conta** (não pode ser alterado após o cadastro).
- **Nome do titular da conta** (pode ser alterado posteriormente, por exemplo, em caso de casamento).
- **Valor de depósito inicial** (opcional):
  - Se o titular não tiver dinheiro para depositar no momento da abertura da conta, o saldo inicial será zero.

### Regras de Negócio

1. **Número da conta**:
   - Não pode ser alterado após o cadastro.

2. **Nome do titular**:
   - Pode ser alterado posteriormente.

3. **Saldo da conta**:
   - Não pode ser alterado livremente.
   - O saldo só pode ser modificado por meio de:
     - **Depósitos**: Aumentam o saldo.
     - **Saques**: Diminuem o saldo, com uma taxa de $5.00 por saque.
   - O saldo pode ficar negativo se não houver fundos suficientes para realizar o saque e/ou pagar a taxa.

### Funcionalidades do Programa

1. **Cadastro de Conta**:
   - Permitir o cadastro de uma conta bancária.
   - Dar a opção de informar ou não o valor de depósito inicial.

2. **Operações Bancárias**:
   - Realizar um depósito.
   - Realizar um saque.

3. **Exibição de Dados**:
   - Mostrar os dados da conta após cada operação.

### Observações

- O programa deve garantir que as regras de negócio sejam respeitadas.
- A taxa de saque de $5.00 deve ser aplicada a cada operação de saque.