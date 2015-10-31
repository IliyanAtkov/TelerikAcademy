function solve(params) {
	var s = parseInt(params[0]);
	var count = 0;
	for (var i = 0; i < s / 2; i++) {
		for (var k = 0; k < s / 2; k++) {
			for (var z = 0; z < s; z++) {

				var result = (i * 4) + (k * 10) + (z * 3);
				if (result === s) {
					count++;
					break;
				}
				if (result > s) {
					break;
				}
			}
		}
	}

	return count;
}solve([10]);