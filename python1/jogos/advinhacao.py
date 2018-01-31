print('*******************************')
print('Bem vindo ao jogo de Advinhação')
print('*******************************')

numero_secreto = 42

chute = input('Digite o seu número: ')
chute = int(chute)

print('Você digitou ', chute)

if(numero_secreto == chute):
    print('Você acertou!')
else:
    print('Você errou!')

print('Fim do jogo!')