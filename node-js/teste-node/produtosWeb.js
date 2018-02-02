// Include
var http = require('http');
var porta = 3000;
var ip = "localhost";

// Cria o Servidor
var server = http.createServer(function(req, res){
	// Headers
	res.writeHead(    200, {'Content-Type': 'text/html'});
	if(req.url == "/produtos"){
		// Envio de resposta
		res.end("<html><body><h1>Listando os produtos da loja</h1></body></html>");
	}
	else{
		// Envio de resposta
		res.end("<html><body><h1>Home da Casa do Codigo</h1></body></html>");
	}
});

// Porta a ser ouvida pelo servidor
server.listen(porta, ip);


console.log('Servidor está rodando!')