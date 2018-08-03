# SeleniumGridParallelTests

### Framework Advanced Report Tests 

### Pre requirements:

### Advanced Manager Report:
1. Download and Install MongoDB: https://www.mongodb.com/download-center#community
2. Download and Run Klov .jar : http://extentreports.com/community/


### Framework Dependencies:
1. Extent Reports
2. Nunit
3. Selenium Webdriver

### Setup Parallelizable tests
#### Selenium Grid Selenium Standalone
1. Download Selenium Standalone Server .jar https://www.seleniumhq.org/download/
2. Run jar file and create hub: java -jar selenium-server-standalone-<version>.jar -role hub
3. Run lar file and register node: java -jar selenium-server-standalone-<version>.jar -role node  -hub http://localhost:4444/grid/register
  
#### Docker Zalenium (Scalable container based Selenium Grid)
1. download and install docker
2. Pull docker-selenium: docker pull elgalu/selenium 
3. Pull Zalenium: docker pull dosel/zalenium
4. Run it:  docker run --rm -ti --name zalenium -p 4444:4444 \
    -v /var/run/docker.sock:/var/run/docker.sock \
    -v /tmp/videos:/home/seluser/videos \
    --privileged dosel/zalenium start
        
### Setup Advanced Report:

1. Run MongoDB
2. Run Klov: java -jar klov-x.x.x. .jar

3. Open Klov Manage and select Project: (Default port: localhost:80)

![](https://uploaddeimagens.com.br/images/001/537/309/original/Imagem_2.png?1533008533)

4. Run all tests SeleniumGridTest Solution:

5. Refresh and verify report manager:
- All executions will be saved here! (In MongoDB Database)

![](https://uploaddeimagens.com.br/images/001/537/306/original/Imagem_11.png?1533008282)

![](https://uploaddeimagens.com.br/images/001/537/302/original/Imagem_10.png?1533008027)

6. Check bin folder in project: .\SeleniumGridTest\SeleniumGridTest\bin\Debug\extent.html
- Last execution will be saved here.

![](https://uploaddeimagens.com.br/images/001/537/293/original/Imagem_6.png?1533007674)

![](https://uploaddeimagens.com.br/images/001/537/294/original/Imagem_7.png?1533007754)

![](https://uploaddeimagens.com.br/images/001/537/295/original/Imagem_8.png?1533007796)

![](https://uploaddeimagens.com.br/images/001/537/296/original/Imagem_9.png?1533007860)

