SOURCES       := $(wildcard Paste/*.cs)
CONFIGURATION := Release
OUTPUT        := Paste\bin\$(CONFIGURATION)\paste.exe

$(OUTPUT): $(SOURCES)
	dotnet build -c Release

.PHONY: build
build: $(OUTPUT)

.PHONY: install
install: build
	copy $(OUTPUT) $(USERPROFILE)\bin
