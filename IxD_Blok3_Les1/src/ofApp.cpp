#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup() {
	ofSetCircleResolution(50);
	font.load("Morganite-SemiBold.ttf", 61);

	try {
		string databasePath = ofToDataPath("roslingdb.db", true);
		db = new SQLite::Database(databasePath);
	}
	catch (const std::exception& e) {
		ofLogError() << e.what() << endl;
	}
}

//--------------------------------------------------------------
void ofApp::update(){

}

//--------------------------------------------------------------
void ofApp::draw(){
	SQLite::Statement query(*db, "SELECT * FROM population WHERE year=?");

	int year = years[yearIndex];
	query.bind(1, year);

	while (query.executeStep()) {



		ofSetColor(ofColor::blue);
		popNLLerpValue = ofLerp(popNLLerpValue, query.getColumn("nl").getDouble(),0.05);
		ofDrawCircle(100, 100, popNLLerpValue);

		ofSetColor(ofColor::red);
		popZHLerpValue = ofLerp(popZHLerpValue, query.getColumn("zh").getDouble(), 0.05);
		ofDrawCircle(300, 100, popZHLerpValue);

		ofSetColor(ofColor::purple);
		popAUHLerpValue = ofLerp(popAUHLerpValue, query.getColumn("au").getDouble(), 0.05);
		ofDrawCircle(500, 100, popAUHLerpValue);

		lerpYear = ofLerp(lerpYear, years[yearIndex], 0.1);
		ofSetColor(ofColor::black);
		font.drawString(ofToString((int)lerpYear), 200, 500);
	}
}

//--------------------------------------------------------------
void ofApp::keyPressed(int key){

}


//--------------------------------------------------------------
void ofApp::mouseMoved(int x, int y ){
	yearIndex = ofMap(x, 0, ofGetWidth(), 0, 5);
}

