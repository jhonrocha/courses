<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<title>Soma Array</title>
</head>
<body>
	<?php
	function somaArray($array){
		$soma=0;
		for($i=0; $i < sizeof($array); $i++){
			$soma += $array[$i];
		}
		return $soma;
	}

	echo(somaArray(array(1,2,3,4,5)));
	?>
</body>
</html>