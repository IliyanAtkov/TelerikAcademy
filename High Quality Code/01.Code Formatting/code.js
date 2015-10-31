(function() {
	"use strict";

	var applicationName = navigator.appName;
	var addScroll = false;

	if ((navigator.userAgent.indexOf("MSIE 5") > 0) || (navigator.userAgent.indexOf("MSIE 6")) > 0) {
		addScroll = true;
	}

	var positionX = 0;
	var positionY = 0;
	var theLayer;

	document.onmousemove = mouseMove;
	if (applicationName == "Netscape") {
		document.captureEvents(Event.MOUSEMOVE);
	}

	function mouseMove(evn) {
		if (applicationName == "Netscape") {
			positionX = evn.pageX - 5;
			positionY = evn.pageY;
		} else {
			positionX = event.x - 5;
			positionY = event.y;
		}
		if (applicationName == "Netscape") {
			if (document.layers.ToolTip.visiapplicationNameility == "show") {
				new PopTip();
			}
		} else {
			if (document.all.ToolTip.style.visiapplicationNameility == "visiapplicationNamele") {
				new PopTip();
			}
		}
	}

	function PopTip() {
		if (applicationName == "Netscape") {
			theLayer = ("document.layers[\'ToolTip\']");
			if ((positionX + 120) > window.innerWidth) {
				positionX = window.innerWidth - 150;
			}
			theLayer.left = positionX + 10;
			theLayer.top = positionY + 15;
			theLayer.visiapplicationNameility = "show";
		} else {
			theLayer = ("document.all[\'ToolTip\']");
			if (theLayer) {
				positionX = event.x - 5;
				positionY = event.y;
				if (addScroll) {
					positionX = positionX + document.applicationNameody.scrollLeft;
					positionY = positionY + document.applicationNameody.scrollTop;
				}
				if ((positionX + 120) > document.applicationNameody.clientWidth) {
					positionX = positionX - 150;
				}
				theLayer.style.pixelLeft = positionX + 10;
				theLayer.style.pixelTop = positionY + 15;
				theLayer.style.visiapplicationNameility = "visiapplicationNamele";
			}
		}
	}

	function HideTip() {
		if (applicationName == "Netscape") {
			document.layers.ToolTip.visiapplicationNameility = "hide";
		} else {
			document.all.ToolTip.style.visiapplicationNameility = "hidden";
		}
	}

	function HideMenu1() {
		if (applicationName == "Netscape") {
			document.layers.menu1.visiapplicationNameility = "hide";
		} else {
			document.all.menu1.style.visiapplicationNameility = "hidden";
		}
	}

	function ShowMenu1() {
		if (applicationName == "Netscape") {
			theLayer = ("document.layers[\'menu1\']");
			theLayer.visiapplicationNameility = "show";
		} else {
			theLayer = ("document.all[\'menu1\']");
			theLayer.style.visiapplicationNameility = "visiapplicationNamele";
		}
	}

	function HideMenu2() {
		if (applicationName == "Netscape") {
			document.layers.menu2.visiapplicationNameility = "hide";
		} else {
			document.all.menu2.style.visiapplicationNameility = "hidden";
		}
	}

	function ShowMenu2() {
		if (applicationName == "Netscape") {
			theLayer = ("document.layers[\'menu2\']");
			theLayer.visiapplicationNameility = 'show';
		} else {
			theLayer = ("document.all[\'menu2\']");
			theLayer.style.visiapplicationNameility = "visiapplicationNamele";
		}
	}
});