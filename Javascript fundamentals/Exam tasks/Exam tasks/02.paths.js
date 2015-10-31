function solve(params) {
	var inputRowAndCol = params[0].split(' ');
	var r = parseInt(inputRowAndCol[0]);
	var c = parseInt(inputRowAndCol[1]);
	var words = [];
	for (var i = 0; i < r; i++) {
		for (var k = 0; k < c; k++) {
			words[i] = params[i + 1].split(' ');
		}
	}
	var currentRow = 0;
	var currentCol = 0;
	var visited = [];
	var points = 0;
	var pointsRowCalc = 0;
	var success = false;
	while (true) {
		if (words[currentRow][currentCol] === true) {
			console.log("failed at (" + currentRow + ", " + currentCol + ")");
			break;
		}
		if (success === true) {
			points = points + calculatePoints(currentRow, currentCol);
			console.log("successed with " + points);
			break;
		}

		

		var direction = words[currentRow][currentCol];
		if (direction === 'dr') {
			if (currentRow >= r - 1 || currentCol >= c - 1) {
				success = true;
				continue;
			}
				points = points + calculatePoints(currentRow, currentCol);
				words[currentRow][currentCol] = true;
				currentRow++;
				currentCol++;
		}
		else if (direction === 'dl') {
			if (currentRow >= r - 1 || currentCol <= 0) {
				success = true;
				continue;
			}
				points = points + calculatePoints(currentRow, currentCol);
				words[currentRow][currentCol] = true;
				currentRow++;
				currentCol--;
		}

		else if (direction === 'ur') {
			if (currentRow <= 0 || currentCol >= c - 1) {
				success = true;
				continue;
			}
			while (true) {
				if (currentRow <= 0 || currentCol >= c - 1) {
					break;
				}
				points = points + calculatePoints(currentRow, currentCol);
				words[currentRow][currentCol] = true;
				currentRow--;
				currentCol++;
			}
		}
		else if (direction === 'ul') {
			if (currentRow <= 0 || currentCol <= 0) {
				success = true;
				continue;
			}
			while (true) {
				if (currentRow <= 0 || currentCol <= 0) {
					break;
				}
				points = points + calculatePoints(currentRow, currentCol);
				words[currentRow][currentCol] = true;
				currentRow--;
				currentCol--;
			}
		}
		
	}
	function calculatePoints(currentRow, currentCol) {
		var pointsRowCalc = currentRow * 2;
		if (pointsRowCalc == 0) {
			pointsRowCalc = 1;
		}

		var points = pointsRowCalc + currentCol;
		return points;
		}
}

 solve([
  '3 5',
  'dr dl dr ur ul',
  'dr dr ul ur ur',
  'dl dr ur dl ur' ]); solve([
   '3 5',
   'dr dl dl ur ul',
   'dr dr ul ul ur',
   'dl dr ur dl ur'
 ]
 )