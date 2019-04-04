#pragma once

#include "ofMain.h"
#include "ofxSQLiteCPP.h"


class ofApp : public ofBaseApp {

public:
	void setup();
	void update();
	void draw();

	void keyPressed(int key);
	void mouseMoved(int x, int y);

	int yearIndex;
	int years[9] = { 1995, 2000, 2005, 2010, 2012, 2013, 2014, 2015, 2016};
	float hhSingle;
	float hhMultiple;
	float hhTotaal;
	float hhKids;
	float hhMarried;

	ofTrueTypeFont font;
	ofTrueTypeFont fontYear;
	float lerpYear;

private:
	SQLite::Database* db;

};
