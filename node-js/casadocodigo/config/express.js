// Imports
var app = require('express')();
// Defining View Engine
app.set('view engine','ejs');

module.exports = function(){
	// Initializing Express
	return app;
}