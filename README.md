# DevOpsAssessmentGlobant
Assessment for Globant DevOps 

Please use this request for test microservice:

curl --location 'http://20.75.20.89/api/devops' \
--header 'x-api-key: 2f5ae96c-b558-4c7b-a590-a501ae1c3f6c' \
--header 'Content-Type: application/json' \
--data '{
  "message": "This is a test",
  "to": "Juan Perez",
  "from": "Rita Asturia",
  "toLifeSec": "45"
}'

####
Any other request wil return error message
