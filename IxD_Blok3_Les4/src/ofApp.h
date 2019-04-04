#pragma once

#include "ofMain.h"
#include "ofxGui.h"
#include "ofxJSON.h"

class ofApp : public ofBaseApp {

public:
	void setup();
	void update();
	void draw();

	void keyPressed(int key);

	int dayChanged;
	string temp;
	string time;

	void getTemp();

	ofTrueTypeFont font;

	ofxPanel gui;
	ofxIntSlider intSlider;

	void getData();
	void getTime();
	ofxJSONElement json;
};