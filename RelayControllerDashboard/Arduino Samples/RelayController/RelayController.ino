
// Indicates the baud rate for the serial port communications.
const int BAUD_RATE = 9600;

// Indicates the number of relays supported.
const int RELAY_COUNT = 4;

// Zero-based array containing the Arduino Pin for each relay.
const int RELAY_PIN[RELAY_COUNT] = { A0, A1, A2, A3 };

// Zero-based array containing the Arduino Pin for the override for each relay.
const int OVERRIDE_PIN[RELAY_COUNT] = { 2, 3, 4, 5 };

// Zero-based array containing the last read values of the override pins.
int lastOverride[RELAY_COUNT] = { HIGH, HIGH, HIGH, HIGH };

void setup() {
    // Initialize serial port
    Serial.begin(BAUD_RATE);
    while (!Serial) {
    ; // Wait for serial port to connect (needed for Arduino Leonardo and Micro).
    }

    // Initailize relay and override pins
    for (int pin = 0; pin < RELAY_COUNT; pin++)
    {
        pinMode(RELAY_PIN[pin], OUTPUT);
        digitalWrite(RELAY_PIN[pin], HIGH);
        pinMode(OVERRIDE_PIN[pin], INPUT_PULLUP);
    }

    Serial.println("Arduino Relay Controller Ready");
}

void loop() {

    int relayId;
    bool relayOn;

    checkAndApplyOverrides();
    if (readNextCommand(&relayId, &relayOn))
    {
        updateRelay(relayId, relayOn);
    }
}

// Reads the next command from the serial port, if a command is available. If a command is read, relayId and relayOn are populated and the function returns true. If no command is read or if the command could not be parsed, the function returns false.
bool readNextCommand(int *relayId, bool *relayOn) {
    if (!Serial.available())
    {
        return false;
    }

    String readLine = Serial.readStringUntil('\n');
    readLine.trim();
    if ((readLine.length() != 3) || (readLine.charAt(1) != ' '))
    {
        return false;
    }

    char relayIdCharacter = readLine.charAt(0);
    char relayOnCharacter = readLine.charAt(2);

    if ((relayIdCharacter < '1') || (relayIdCharacter > '4') || (relayOnCharacter < '0') || (relayOnCharacter > '1'))
    {
        return false;
    }

    *relayId = relayIdCharacter - '1';
    *relayOn = relayOnCharacter - '0';
    return true;
}

// Updates the indicated relay to the value specified.
void updateRelay(int relayId, bool relayOn) {
    digitalWrite(RELAY_PIN[relayId], !relayOn);
    Serial.write(relayId + '1');
    Serial.write(' ');
    Serial.write(relayOn + '0');
    Serial.println();
}

void checkAndApplyOverrides() {

    int currentOverride[RELAY_COUNT];

    for (int pin = 0; pin < RELAY_COUNT; pin++)
    {
        currentOverride[pin] = digitalRead(OVERRIDE_PIN[pin]);
        if (currentOverride[pin] != lastOverride[pin])
        {
          updateRelay(pin, !currentOverride[pin]);
          lastOverride[pin] = currentOverride[pin];
        }
    }
}

