import React, { Component } from 'react';
import './Home.css';

export class Betaling extends Component {
  static displayName = Betaling.name;

  // constructor(props) {
  //   super(props);

  render() {
    return (
      <div>
        <br></br>
        <form method="post" action="https://fakepay.azurewebsites.net">
          <input type="hidden" id="amount" name="amount" value="10"></input>
          <input type="hidden" name="reference" value="12345"></input>
          <input type="hidden" name="url" value="https://localhost:7003/api/betaling"></input>
          <button type="submit" onclick="func()">Klik hier om te betalen</button>
        </form>
        <br></br>
      </div>
    );
  }
}
