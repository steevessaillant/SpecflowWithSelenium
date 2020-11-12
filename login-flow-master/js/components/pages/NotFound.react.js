import React, { Component } from 'react';
import { Link } from 'react-router';

class NotFound extends Component {
    componentDidMount() {
        document.title = 'Page Not Found'
    }
  render() {
    return(
      <article>
        <h1>Page not found.</h1>
        <Link to="/" className="btn">Home</Link>
      </article>
    );
  }
}

export default NotFound;
