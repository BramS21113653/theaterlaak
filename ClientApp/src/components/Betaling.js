import React, { Component } from 'react';
import './Home.css';

export class Betaling extends Component {
  static displayName = Betaling.name;
  constructor(props) {
    super(props);
    this.state = {
      stoelen: 1,
      show: true
    };
  }

  IncrementItem = () => {
    this.setState({ stoelen: Math.min(20, this.state.stoelen + 1 )});
  }
  DecreaseItem = () => {
    this.setState({ stoelen: Math.max(1, this.state.stoelen - 1 )});
  }
  Empty = () => {
    this.setState({ stoelen: this.state.stoelen = 1 });
  }

  render() {
    return (
      <div>
        <br></br>
        <div>
        <button onClick={this.Empty}>Empty</button>
        { this.state.show ? <h2>Aantal stoelen: { this.state.stoelen }</h2> : '' }
        <button onClick={this.IncrementItem}>Stoel toevoegen</button>
        <button onClick={this.DecreaseItem}>Stoel verwijderen</button>
        </div><br></br>
        <form method="post" action="https://fakepay.azurewebsites.net">
          <input type="hidden" id="amount" name="amount" value="10"></input>
          <input type="hidden" name="reference" value="12345"></input>
          <input type="hidden" name="url" value="https://localhost:7003/api/betaling"></input>
          <button type="submit" onclick="func()" style={{color: "blue"}}>Klik hier om te betalen</button>
        </form>
        <br></br>
      </div>
    );
  }
}

export default Betaling;