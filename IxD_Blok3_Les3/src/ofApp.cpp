#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup() {
	ofSetCircleResolution(50);
	font.load("Morganite-SemiBold.ttf", 20);
	fontYear.load("Morganite-SemiBold.ttf", 60);

	try {
		string databasePath = ofToDataPath("Huishoudens.db", true);
		db = new SQLite::Database(databasePath);
	}
	catch (const std::exception& e) {
		ofLogError() << e.what() << endl;
	}
}

//--------------------------------------------------------------
void ofApp::update() {

}

//--------------------------------------------------------------
void ofApp::draw() {
	SQLite::Statement query(*db, "SELECT * FROM huishoudens WHERE jaar = ?");

	int year = years[yearIndex];
	query.bind(1, year);

	while (query.executeStep()) {
		ofSetColor(ofColor::blue);
		hhTotaal = ofLerp(hhTotaal, query.getColumn("huishoudens_totaal").getDouble(), 0.01);
		ofDrawCircle(100 , 300, hhTotaal/100000);
		ofSetColor(ofColor::black);
		font.drawString("Huishoudens Totaal", 50, 300);

		ofSetColor(ofColor::red);
		hhSingle = ofLerp(hhSingle, query.getColumn("hh_single").getDouble(), 0.01);
		ofDrawCircle(300, 600 - hhSingle/10000, hhSingle /100000 );
		ofSetColor(ofColor::black);
		font.drawString("Huishoudens Alleenstaand", 250, 600 - hhSingle / 10000);

		ofSetColor(ofColor::purple);
		hhMultiple = ofLerp(hhMultiple, query.getColumn("hh_multiple").getDouble(), 0.01);
		ofDrawCircle(500, 600 - hhMultiple/10000 , hhMultiple /100000);
		ofSetColor(ofColor::black);
		font.drawString("Huishoudens Niet Alleenstaand", 450, 600 - hhMultiple / 10000);

		ofSetColor(ofColor::green);
		hhKids = ofLerp(hhKids, query.getColumn("hh_multiple_kids").getDouble(), 0.01);
		ofDrawCircle(700, 600 - hhKids / 10000, hhKids / 100000);
		ofSetColor(ofColor::black);
		font.drawString("Huishoudens Met Kinderen", 650, 600 - hhKids / 10000);

		ofSetColor(ofColor::orange);
		hhMarried= ofLerp(hhMarried, query.getColumn("hh_multiple_married").getDouble(), 0.01);
		ofDrawCircle(900, 600 - hhMarried / 10000, hhMarried / 100000);
		ofSetColor(ofColor::black);
		font.drawString("Huishoudens Getrouwd", 850, 600 - hhMarried / 10000);

		lerpYear = ofLerp(lerpYear, years[yearIndex], 0.1);
		ofSetColor(ofColor::black);
		fontYear.drawString(ofToString((int)lerpYear), 1000, 300);
	}
}

//--------------------------------------------------------------
void ofApp::keyPressed(int key) {

}


//--------------------------------------------------------------
void ofApp::mouseMoved(int x, int y) {
	yearIndex = ofMap(x, 0, ofGetWidth(), 0, 9);
}

