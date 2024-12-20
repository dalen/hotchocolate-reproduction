Request

```graphql
{
  books(where:  {
     id:  {
        eq: 1
     }
  }) {
    nodes {
      id
      title
    }
  }
}
```

Response:

```json
{
  "errors": [
    {
      "message": "The node ID string has an invalid format.",
      "locations": [
        {
          "line": 2,
          "column": 3
        }
      ],
      "path": [
        "books"
      ],
      "extensions": {
        "originalValue": "1"
      }
    }
  ],
  "data": {
    "books": null
  }
}
```