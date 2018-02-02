// Imports
var configura = require('./config/express');

// Initializing Express
var app = configura();



// GET: produtos/
app.get('/produtos', function(req, res){
	res.render("produtos/lista");
});

// Starting Server
app.listen(3000, function(){
	console.log('Server running!');
});
