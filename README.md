# microservices-k3s

# from windows machine
kubectl proxy

# from Linux machine
sudo k3s kubectl -n kubernetes-dashboard create token admin-user

# from windows machine
http://localhost:8001/api/v1/namespaces/kubernetes-dashboard/services/https:kubernetes-dashboard:/proxy/#/pod?namespace=def