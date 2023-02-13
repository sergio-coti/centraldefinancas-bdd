#language: pt
#encoding: iso-8859-1

Funcionalidade: Autenticar Usuário
	Como um usuário cadastrado no sistema
	Eu quero acessar minha conta
	Para que possa gerenciar minhas finanças

Cenário: Autenticação de usuário com sucesso
	Dado Acessar a página de autenticação de usuários
	E Informar o email de acesso "sergio.coti@gmail.com"
	E Informar a senha de acesso "@Admin123"
	Quando Solicitar a realização do acesso
	Então Sistema autentica o usuário e exibe a página dashboard

Cenário: Acesso negado
	Dado Acessar a página de autenticação de usuários
	E Informar o email de acesso "teste@teste.com"
	E Informar a senha de acesso "@Teste123"
	Quando Solicitar a realização do acesso
	Então Sistema informa que o acesso é negado