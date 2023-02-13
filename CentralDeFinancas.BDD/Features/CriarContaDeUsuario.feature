﻿#language: pt
#encoding: iso-8859-1

Funcionalidade: Criar conta de usuário
	Como uma pessoa que navega no sistema
	Eu quero criar uma conta de usuário
	Para que possa acessar minha conta e gerenciar minhas finanças

Cenário: Cadastro de usuário com sucesso
	Dado Acessar a página de cadastro de usuário
	E Informar o nome
	E Informar o email
	E Informar e Confirmar a senha
	Quando Solicitar a realização do cadastro
	Então Sistema informa que o usuário foi cadastrado com sucesso

Cenário: Campos obrigatórios
	Dado Acessar a página de cadastro de usuário
	E Manter os campos com valor vazio
	Quando Solicitar a realização do cadastro
	Então Sistema informa que todos os campos são obrigatórios