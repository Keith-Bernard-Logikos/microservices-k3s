docker build -t keithbernard/commandservice .
docker push keithbernard/commandservice

docker run -p 8080:80 keithbernard/commandservice