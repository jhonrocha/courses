// Imports
var express = require('express');
// Initializing Express
var app = express();

// Defining View Engine
app.set('view engine','ejs');

// GET: produtos/
app.get('/produtos', function(req, res){
	res.render("produtos/lista");
});

// Starting Server
app.listen(3000, function(){
	console.log('Server running!');
});
