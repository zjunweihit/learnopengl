#version 330 core
out vec4 FragColor;
in vec2 texCoord;
uniform sampler2D ourTexture1;
uniform sampler2D ourTexture2;

void main()
{
	//FragColor = texture(ourTexture, texCoord);// * vec4(ourColor, 1.0f);
	FragColor = mix(texture(ourTexture1, texCoord), texture(ourTexture2, texCoord), 0.3);
}