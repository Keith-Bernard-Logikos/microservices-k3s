# Ingress-Nginx Controller
kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.8.2/deploy/static/provider/cloud/deploy.yaml

# create routing files
ingress-srv.yaml


# Kubernetes dashboard
# from windows machine (kubectl is configured to point to k3s)
kubectl proxy

# from Linux machine (get login token)
k3s kubectl -n kubernetes-dashboard create token admin-user

# from windows machine
http://localhost:8001/api/v1/namespaces/kubernetes-dashboard/services/https:kubernetes-dashboard:/proxy/#/pod?namespace=def


# SQLServer secret
kubectl create secret generic mssql --from-literal=SA_PASSWORD="pa55wOrd!"


# DBeaver connection to SqlServer
# HOST: 192.168.254.176  PORT: 32757 (mssql-loadbalancer port - external port)
# DATABASE: master
# AUTHENTICATION: SQL Server 
# USERNAME: sa PASSWORD pa55wOrd! (from secret)
