# Formato dos métodos da controller:

interface:

```c#
  // \Communication\Requests\RequestRegister
  namespace FirstProject.Communication.Requests;

  public class RequestRegisterUserJSON
  {
      public string Name { get; set; } = string.Empty;
      public string Email { get; set; } = string.Empty;
      public string Password { get; set; } = string.Empty;
  }

  // \Communication\Requests\RequestResponse
  namespace FirstProject.Communication.Responses;

  public class ResponseRegisterUserJSON
  {
      public int Id { get; set; }
      public string Name { get; set; } = string.Empty;
  }
```

```c#
  [Http{METHOD}]
  [ProducesResponseType(typeof(ResponseRegister), StatusCodes.Status{HTTP_METHOD})]
  public IActionResult METHOD([FromBody] RequestRegister request)
  {
    ...
  }
```

ex.: GET
```c#
  [HttpGet] // define o tipo de método - endpoint do tipo GET
  public IActionResult GetAll()
  {
      var response = new User
      {
          Id = 1,
          Age = 37,
          Name = "Tiago",
      };

      return Ok(response);
  }
```

ex.: POST

```c#
  [HttpPost]
  [ProducesResponseType(typeof(ResponseRegisterUserJSON), StatusCodes.Status201Created)]
  public IActionResult Create([FromBody] RequestRegisterUserJSON request)
  {
      var response = new ResponseRegisterUserJSON{
          Id = 1,
          Name = request.Name,
      };

      return Created(string.Empty, response);
  }
```

ex.: GET BY ID

```c#
  [HttpGet]
  [Route("id")]
  [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
  [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
  public IActionResult GetById([FromRoute] int id)
  {
      var response = new User
      {
          Id = 1,
          Age = 37,
          Name = "Tiago",
      };

      return Ok(response);
  }
```

```c#
  [HttpPut]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  public IActionResult Update(
      [FromRoute] int id,
      [FromBody] RequestRegisterUserJSON request
  ) {
      return NoContent();
  }
```

```c#
  [HttpDelete]
  [ProducesResponseType(StatusCodes.Status204NoContent)]
  public IActionResult Delete(
      [FromRoute] int id
  ) {
      return NoContent();
  }
```
