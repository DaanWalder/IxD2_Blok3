#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup(){
	font.load("Morganite-SemiBold.ttf", 50);
	gui.setup();
	gui.add(intSlider.setup("Datum Slider", 1, 1, 7));
	

}

//--------------------------------------------------------------
void ofApp::update(){
	if (intSlider != dayChanged) {
		getTemp();
		getTime();
		dayChanged = intSlider;
		ofLog() << temp;
	}
}

void ofApp::draw() {
	gui.draw();
	ofSetColor(ofColor::blue);
	font.drawString("Datum:" + time, 50, 100);
	font.drawString("Temperatuur:" + temp, 50, 150);
	
}

void ofApp::keyPressed(int key) {
	//getData();
}

void ofApp::getTemp() {
	string url = "http://api.openweathermap.org/data/2.5/forecast?q=Nijmegen,nl&appid=37f584c9d170b496e7abe382b2237a5a&units=metric";
	bool success = json.open(url); // load & parse data from the API url
	if (success) { // loading & parsing was successful?
		ofLog() << json["list"][intSlider]["main"]["temp"] << endl;
		temp = json["list"][intSlider]["main"]["temp"].asString();
	}
	else {
		ofLog() << "Oops. No data!" << endl;
	}
}

void ofApp::getTime() {
	string url = "http://worldclockapi.com/api/json/est/now";
	bool success = json.open(url); // load & parse data from the API url
	if (success) { // loading & parsing was successful?
		ofLog() << json["currentDateTime"] << endl;
		string currentTime = json["currentDateTime"].asString();
		time = currentTime.substr(0, 9) + std::to_string(std::stoi(currentTime.substr(9, 1))+ intSlider);
	}
	else {
		ofLog() << "Oops. No data!" << endl;
	}
}
